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

namespace Lab1
{
    public partial class Form1 : Form
    {
        public const Double tax = .10;
        public Double? subTotal = 0;
        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true; //resize auto
            this.dataGridView1.AllowUserToAddRows = false; //disable user changes

            try
            {
                //deserialize file
                string jsonBook = File.ReadAllText(@"Z:\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\BookList.json");

                //get access to the file
                var dict = JsonConvert.DeserializeObject<Dictionary<string, Book>>(jsonBook);
                comboBox1.Items.Clear();
                foreach (var bookItem in dict) {
                    comboBox1.Items.Add(bookItem.Key.ToString());
                }
            }

            catch
            {
                TotalText.Text = "Check File";
            }
        }

        /// <summary>
        /// When the "Add Title" button is clicked, the selected book and all of its characteristics will appear in 
        /// dataGridView1 and also update the subtotal, tax, and total boxes with correct values and information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTitle_Click(object sender, EventArgs e)
        {
            //get title
            try
            {
                int quantity;
                bool QTY = int.TryParse(QuantityText.Text, out quantity);
                
                if (QTY && quantity != 0 && !(quantity < 0))
                {
                    decimal? totalCost = quantity * Convert.ToDecimal(PriceText.Text);
                    string SelectedItem = (string)comboBox1.SelectedItem;
                    string[] row = new string[] { SelectedItem, "$" + PriceText.Text, quantity.ToString(), "$" + totalCost.ToString() };

                    dataGridView1.Rows.Add(row);
                    subTotal += quantity * Convert.ToDouble(PriceText.Text);
                    Subtotal_Text.Text = "$" + subTotal.ToString();
                    TaxText.Text = (subTotal * tax).ToString();
                    TotalText.Text = "$" + ((subTotal * tax) + subTotal).ToString();
                    QuantityText.Text = quantity.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a Number");
                    QuantityText.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Select a Book");
            }
        }
        /// <summary>
        /// This creates the book and if a certain book is picked, the corresponding text boxes will update with the
        /// correct information in each box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = (string)comboBox1.SelectedItem;
            try
            {
                string jsonBook = File.ReadAllText(@"Z:\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\BookList.json");
                JObject JSON = JObject.Parse(jsonBook);
                JObject targetBook = (JObject)JSON[SelectedItem];
                string s_targetBook = targetBook.ToString();
                Book found = new Book();
                Newtonsoft.Json.JsonConvert.PopulateObject(s_targetBook, found);
                AuthorText.Text = found.author; ;
                IsbnText.Text = found.ISBN;
                PriceText.Text = found.price.ToString();
            }

            catch
            {
                AuthorText.Clear();
                IsbnText.Clear();
                PriceText.Clear();
            }
            QuantityText.Focus();
            
        }

        public void SaveToTxt(string receipt)
        {
            //write string to file
            System.IO.File.WriteAllText(@"Z:\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\Receipt.txt", receipt);
        }


        /// <summary>
        /// When the "Confirm Order" button is clicked, a new message box will appear confirming that an order has been 
        /// placed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> order = new Dictionary<string, string>();
            string totalItems = "Subtotal: " + Subtotal_Text.Text 
                                + "   Tax: 10.00%" 
                                + "   Tax Total: " + TaxText.Text 
                                + "   Total: " + TotalText.Text;
            order.Add("Order Total", totalItems);
            string dateTimeString = $"{DateTime.Today.ToString("d")} {DateTime.Now.ToString("HH:mm:ss")}";
            order.Add("Transaction Completed", dateTimeString);
            string receipt = JsonConvert.SerializeObject(order, Formatting.Indented);
            SaveToTxt(receipt);
            dataGridView1.Rows.Clear(); //clear fields
            //ClearTextBoxes();//clear boxes
            MessageBox.Show("Thank you! Your order has been placed!");
        }
        /// <summary>
        /// If "Cancel" is pressed, the user will be prompted to make sure that they still want to cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to cancel the order?", "Cancel Order?", MessageBoxButtons.YesNo))
            {
                AuthorText.Text = "";
                IsbnText.Text = "";
                PriceText.Text = "";
                QuantityText.Text = "";
                TotalText.Text = "";
                TaxText.Text = "";
                Subtotal_Text.Text = "";
                dataGridView1.Rows.Clear();
            }
        }
    }
}