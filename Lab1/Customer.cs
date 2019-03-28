using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class Customer : Form
    {
        string name = "[^A-Za-z']";
        string phone = "^((1-([(][0-9]{3}[)]|[0-9]{3})-)[0-9]{3}-[0-9]{4})$";
        string email = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+[.][A-Z]{2,4}$";
        string zip = @"^\d{5}(?:[-\s]\d{4})?$";
        public List<string> customerNames = new List<string>();
        public string path = @"Z:\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\Customers.json";
        public string SelectedItem;
        public string tempfirst;
        public string templast;
        int newCustomerRequested = 0;
        public Customer()
        {
            InitializeComponent();
            try
            {
                //deserialize file
                string jsonCust = File.ReadAllText(@"Z:\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\Customers.json");

                //get access to the file
                var dict = JsonConvert.DeserializeObject<Dictionary<string, Book>>(jsonCust);
                comboBox.Items.Clear();
                foreach (var cust in dict)
                {
                    comboBox.Items.Add(cust.Key.ToString());
                }
            }

            catch
            {
                statusTextBox.Text = "Check File";
            }
            /*
            try
            {
                populateComboBox();
                this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            catch
            {
                statusTextBox.Text = "Check JSON File/Location";
            }*/
        }
        private void populateComboBox()
        {
            // deserialize JSON directly from a file
            string customerJSON = File.ReadAllText(path);
            JObject json = JObject.Parse(customerJSON);
            //access books
            JArray custoList = (JArray)json["CustomerList"];
            //made list of only book names for the combobox. See JSON File
            List<string> Customers = JsonConvert.DeserializeObject<List<string>>(custoList.ToString());
            comboBox.Items.Clear();
            customerNames.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                comboBox.Items.Add(json[Customers[i]]["first"].ToString() + " " + json[Customers[i]]["last"].ToString());
                customerNames.Add(json[Customers[i]]["first"].ToString() + " " + json[Customers[i]]["last"].ToString());
            }
        }
        private CustomerList CreateCustomer()
        {
            CustomerList custo = new CustomerList();

            if (firstTextBox.Text == "" || Regex.IsMatch(firstTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please Enter First Name", "First Name is a required field");
                firstTextBox.Focus();
            }
            else if (lastTextBox.Text == "" || Regex.IsMatch(lastTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please Enter valid Last Name", "Last name is a required field");
                firstTextBox.Focus();
            }
            else if (PhoneTextBox.Text == "" || Regex.IsMatch(PhoneTextBox.Text, phone))
            {
                custo = null;

                MessageBox.Show("Please Enter valid 10 digit Phone Number e.g: xxxxxxxxxx", "First Name is a required field");
                firstTextBox.Focus();
            }
            else if (addressTextBox.Text == "" || Regex.IsMatch(addressTextBox.Text, zip))
            {
                custo = null;

                MessageBox.Show("Please Enter Valid Address", "Address is a required field");
                addressTextBox.Focus();
            }
            else if (stateTextBox.Text == "" || Regex.IsMatch(stateTextBox.Text, name))
            {
                custo = null;

                MessageBox.Show("Please enter Valid State", "State is a required field");
                stateTextBox.Focus();
            }
            else if (cityTextBox.Text == "")
            {
                custo = null;

                MessageBox.Show("Please enter valid city", "city is a required field");
                cityTextBox.Focus();
            }
            else if (zipTextBox.Text == "")
            {
                custo = null;

                MessageBox.Show("Please enter a valid 5 digit zip code", "Zip is a required field");
                zipTextBox.Focus();
            }
            else if (emailTextBox.Text == "" || Regex.IsMatch(emailTextBox.Text, email))
            {
                MessageBox.Show("Please enter a valid Email", "Email is a required field");
                custo = null;
                emailTextBox.Focus();
            }
            else
            {
                custo.first = firstTextBox.Text;
                custo.last = lastTextBox.Text;
                custo.address = addressTextBox.Text;
                custo.city = cityTextBox.Text;
                custo.state = stateTextBox.Text;
                custo.zip = zipTextBox.Text;
                custo.phone = PhoneTextBox.Text;
                custo.email = emailTextBox.Text;
            }


            return custo;
        }

        void WriteToJSON(string newCustomer)
        {
            string newFile = File.ReadAllText(path);
            if (newFile == "")
                newFile = newCustomer;
            else
            {
                newFile = newFile.Remove(newFile.Length - 1, 1);
                newCustomer = newCustomer.Remove(0, 1);
                newCustomer = newCustomer.Remove(newCustomer.Length - 1, 1);
                newFile = newFile + ',' + newCustomer + '}';
            }

            File.WriteAllText(path, newFile);



        }
        private int checkIfCustoExists(string custoName)
        {
            int result = 1;
            foreach (var name in customerNames)
            {
                if (name == custoName)
                    return 0;
            }
            return result;
        }

        void AddCustomer(string custoName) //custoName = first + last
        {
            CustomerList newCustomer = new CustomerList();

            //If employee exists
            if (checkIfCustoExists(custoName) == 1)
            {

                newCustomer = CreateCustomer();
                if (newCustomer is null)
                {
                    return;
                }
                string custoJSON = File.ReadAllText(path);
                JObject json = JObject.Parse(custoJSON);
                //access employees
                JArray custoList = (JArray)json["CustomerList"];
                //add customer name to list
                custoList.Add(custoName);


                // Create a file to write to.
                File.WriteAllText(path, json.ToString());



                string temp = json.ToString();

                //Make JSON string from dictionary
                string newCustomerJSON = CreateCustomerJSON(custoName, newCustomer);
                //Write to employee JSON
                WriteToJSON(newCustomerJSON);

                //**Write Employee Successfully Added**
                statusTextBox.Text = "SUCCESS - EMPLOYEE ADDED";


                //**Write customer Successfully Added**
                statusTextBox.Text = "SUCCESS - CUSTOMER ADDED";
                newCustomerRequested = 0;

            }
            //If customer already exists
            else
                statusTextBox.Text = "ERROR - CUSTOMER ALREADY EXISTS";
        }

        string CreateCustomerJSON(string username, CustomerList newCustomer)
        {
            //Create employee dictionary
            Dictionary<string, CustomerList> tempCustomer = new Dictionary<string, CustomerList>
                {
                    { username, newCustomer }
                };


            //Make JSON string from dictionary
            return JsonConvert.SerializeObject(tempCustomer, Formatting.Indented);
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (string)comboBox.SelectedItem;
            try
            {
                //access books
                string BookJSON = File.ReadAllText(path);
                JObject json = JObject.Parse(BookJSON);

                JObject CustoTarget = (JObject)json[SelectedItem];

                string custo_target = CustoTarget.ToString();

                CustomerList foundCusto = new CustomerList();
                Newtonsoft.Json.JsonConvert.PopulateObject(custo_target, foundCusto);
                firstTextBox.Text = foundCusto.first;
                lastTextBox.Text = foundCusto.last;
                addressTextBox.Text = foundCusto.address;
                cityTextBox.Text = foundCusto.city;
                stateTextBox.Text = foundCusto.state;
                zipTextBox.Text = foundCusto.zip;
                PhoneTextBox.Text = foundCusto.phone;
                emailTextBox.Text = foundCusto.email;

                tempfirst = foundCusto.first;
                templast = foundCusto.last;

            }
            catch
            {
                //clear form
                firstTextBox.Clear();
                lastTextBox.Clear();
                addressTextBox.Clear();
                cityTextBox.Clear();
                stateTextBox.Clear();
                zipTextBox.Clear();
                PhoneTextBox.Clear();
                //emailTextBox.Clear();
            }

            comboBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.comboBox.Enabled = true;
            newCustomerRequested = 0;
            ClearTextBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 store = new Form1();
            store.Show();
            Hide();
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            this.comboBox.Enabled = false;
            newCustomerRequested = 1;
            ClearTextBoxes();

        }

        private void ClearTextBoxes() //Found on stack overflow
        {
            comboBox.SelectedIndex = -1;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>//lambda expression
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (newCustomerRequested == 1)
            {
                this.comboBox.Enabled = false;
                AddCustomer(firstTextBox.Text + " " + lastTextBox.Text);
                populateComboBox();

            }
            else if (newCustomerRequested == 0)
            {
                this.comboBox.Enabled = true;

                if (firstTextBox.Text == "" || Regex.IsMatch(firstTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter First Name", "First Name is a required field");
                    firstTextBox.Focus();
                }
                else if (lastTextBox.Text == "" || Regex.IsMatch(lastTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter Last Name", "Last name is a required field");
                    firstTextBox.Focus();
                }
                else if (PhoneTextBox.Text == "" || Regex.IsMatch(PhoneTextBox.Text, phone))
                {

                    MessageBox.Show("Please Enter Phone Number", "First Name is a required field");
                    firstTextBox.Focus();
                }
                else if (addressTextBox.Text == "" || Regex.IsMatch(addressTextBox.Text, zip))
                {
                    MessageBox.Show("Please Enter Address", "Address is a required field");
                    addressTextBox.Focus();
                }
                else if (stateTextBox.Text == "" || Regex.IsMatch(stateTextBox.Text, name))
                {

                    MessageBox.Show("Please Enter State", "State is a required field");
                    stateTextBox.Focus();
                }
                else if (cityTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter city", "city is a required field");
                    cityTextBox.Focus();
                }
                else if (zipTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter Zip", "Zip is a required field");
                    zipTextBox.Focus();
                }
                else if (emailTextBox.Text == "" || Regex.IsMatch(emailTextBox.Text, email))
                {
                    MessageBox.Show("Please Enter Email", "Email is a required field");
                    emailTextBox.Focus();
                }
                else
                {

                    if (SelectedItem is null)
                    {
                        MessageBox.Show("Please select customer from list", "Save Error");
                        return;
                    }
                    string custoJSON = File.ReadAllText(path);
                    JObject json = JObject.Parse(custoJSON);
                    json[SelectedItem]["address"] = addressTextBox.Text;
                    json[SelectedItem]["city"] = cityTextBox.Text;
                    json[SelectedItem]["state"] = stateTextBox.Text;
                    json[SelectedItem]["zip"] = zipTextBox.Text;
                    json[SelectedItem]["phone"] = PhoneTextBox.Text;
                    json[SelectedItem]["email"] = emailTextBox.Text;
                    if (tempfirst != firstTextBox.Text.ToString() || templast != lastTextBox.Text.ToString())
                    {
                        MessageBox.Show("Cannot update first or last name, please create new customer", "Overwrite Error");
                        firstTextBox.Text = tempfirst;
                        lastTextBox.Text = templast;
                        return;
                    }
                    File.WriteAllText(path, json.ToString());
                    populateComboBox();
                    ClearTextBoxes();

                    statusTextBox.Text = "Customer Info Updated Successfully";
                }
            }
            this.comboBox.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}