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
        public const Double tax = .1;
        public Double? subTotal = 0;
        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true; //resize auto
            this.dataGridView1.AllowUserToAddRows = false; //disable user changes

            try
            {
                //deserialize file
                string jsonBook = File.ReadAllText(@"\\Mac\Home\Desktop\Fourth Year (F18-S19)\CompE561\Lab1\Lab1\bin\Debug\BookList.json");
                JObject JSON = JObject.Parse(jsonBook);
                //get access to the file
                JArray BookList = (JArray)JSON["Books"];
                List<string> Books = JsonConvert.DeserializeObject<List<string>>(BookList.ToString());
                comboBox1.Items.Clear();
                for (int x = 0; x < Books.Count; x++)
                {
                    comboBox1.Items.Add(JSON[Books[x]]["bookName"].ToString());
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
            string SelectedItem = (string)comboBox1.SelectedItem;
            int Quantity = Int32.Parse(QuantityText.Text);
            Double TotalCost = Quantity * Convert.ToDouble(PriceText.Text);
            // Populate the rows.
            string[] row = new string[] { SelectedItem, "$" + PriceText.Text, Quantity.ToString(), "$" + TotalCost.ToString() };

            dataGridView1.Rows.Add(row);
            string sSubTotal = Subtotal_Text.Text.Replace("$", "");
            if (sSubTotal.Equals(""))
            {
                sSubTotal = "0";
            }

            double dSubTotal = Convert.ToDouble(sSubTotal);
            dSubTotal += TotalCost;
            Subtotal_Text.Text = dSubTotal.ToString("C");

            double tax = dSubTotal * 0.075;
            TaxText.Text = tax.ToString("C");

            double total = dSubTotal + tax;
            TotalText.Text = total.ToString("C");

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
            string Book1Name = "The Kite Runner";
            decimal Book1Price = 14.40m;
            string Book1ISBN = "9781594631931";
            string Book1Author = "Khaled Hosseini";

            string Book2Name = "Charlie and the Chocolate Factory";
            decimal Book2Price = 7.20m;
            string Book2ISBN = "9780142410318";
            string Book2Author = "Roald Dahl";

            string Book3Name = "Twilight";
            decimal Book3Price = 14.44m;
            string Book3ISBN = "9780316015844";
            string Book3Author = "Stephenie Meyer";

            Book Book1 = new Book(Book1Name, Book1Author, Book1ISBN, Book1Price);
            Book Book2 = new Book(Book2Name, Book2Author, Book2ISBN, Book2Price);
            Book Book3 = new Book(Book3Name, Book3Author, Book3ISBN, Book3Price);
            string test = comboBox1.SelectedText;
            string test2 = e.ToString();
            if (SelectedItem == "The Kite Runner")
            {
                AuthorText.Text = Book1.author;
                IsbnText.Text = Book1.ISBN;
                PriceText.Text = Book1.price.ToString();
            }
            else if (SelectedItem == "Charlie and the Chocolate Factory")
            {
                AuthorText.Text = Book2.author;
                IsbnText.Text = Book2.ISBN;
                PriceText.Text = Book2.price.ToString();
            }
            else if (SelectedItem == "Twilight")
            {
                AuthorText.Text = Book2.author;
                IsbnText.Text = Book2.ISBN;
                PriceText.Text = Book2.price.ToString();
            }
            else
            {
                AuthorText.Clear();
                IsbnText.Clear();
                PriceText.Clear();
                TotalText.Text = "Select a Book to purchase!";
            }
        }
        /// <summary>
        /// When the "Confirm Order" button is clicked, a new message box will appear confirming that an order has been 
        /// placed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount >= 1)
            {
                MessageBox.Show("You have placed an order!");
                AuthorText.Text = "";
                IsbnText.Text = "";
                PriceText.Text = "";
                QuantityText.Text = "";
                TotalText.Text = "";
                TaxText.Text = "";
                Subtotal_Text.Text = "";
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Please add a book.");
                comboBox1.Focus();
            }
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