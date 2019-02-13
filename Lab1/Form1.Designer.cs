namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTitle = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Subtotal_Text = new System.Windows.Forms.TextBox();
            this.TaxText = new System.Windows.Forms.TextBox();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.IsbnText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTitle
            // 
            this.AddTitle.Location = new System.Drawing.Point(411, 307);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(6);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(150, 44);
            this.AddTitle.TabIndex = 0;
            this.AddTitle.Text = "Add Title";
            this.AddTitle.UseVisualStyleBackColor = true;
            this.AddTitle.Click += new System.EventHandler(this.AddTitle_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(70, 135);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(81, 25);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author:";
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(544, 135);
            this.IsbnLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(66, 25);
            this.IsbnLabel.TabIndex = 2;
            this.IsbnLabel.Text = "ISBN:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(312, 200);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 25);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(281, 249);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(98, 25);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Location = new System.Drawing.Point(406, 379);
            this.OrderSummaryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(162, 25);
            this.OrderSummaryLabel.TabIndex = 5;
            this.OrderSummaryLabel.Text = "Order Summary";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(25, 690);
            this.SubtotalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(97, 25);
            this.SubtotalLabel.TabIndex = 6;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(374, 693);
            this.TaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(54, 25);
            this.TaxLabel.TabIndex = 7;
            this.TaxLabel.Text = "Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(686, 693);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total:";
            // 
            // Subtotal_Text
            // 
            this.Subtotal_Text.Location = new System.Drawing.Point(134, 690);
            this.Subtotal_Text.Margin = new System.Windows.Forms.Padding(6);
            this.Subtotal_Text.Name = "Subtotal_Text";
            this.Subtotal_Text.Size = new System.Drawing.Size(196, 31);
            this.Subtotal_Text.TabIndex = 9;
            this.Subtotal_Text.TextChanged += new System.EventHandler(this.Subtotal_Text_TextChanged);
            // 
            // TaxText
            // 
            this.TaxText.Location = new System.Drawing.Point(440, 693);
            this.TaxText.Margin = new System.Windows.Forms.Padding(6);
            this.TaxText.Name = "TaxText";
            this.TaxText.Size = new System.Drawing.Size(196, 31);
            this.TaxText.TabIndex = 10;
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(752, 693);
            this.TotalText.Margin = new System.Windows.Forms.Padding(6);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(196, 31);
            this.TotalText.TabIndex = 11;
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Location = new System.Drawing.Point(218, 787);
            this.ConfirmOrderButton.Margin = new System.Windows.Forms.Padding(6);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(210, 44);
            this.ConfirmOrderButton.TabIndex = 12;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Location = new System.Drawing.Point(549, 787);
            this.CancelOrderButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(150, 44);
            this.CancelOrderButton.TabIndex = 13;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(163, 135);
            this.AuthorText.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(196, 31);
            this.AuthorText.TabIndex = 14;
            // 
            // IsbnText
            // 
            this.IsbnText.Location = new System.Drawing.Point(622, 135);
            this.IsbnText.Margin = new System.Windows.Forms.Padding(6);
            this.IsbnText.Name = "IsbnText";
            this.IsbnText.Size = new System.Drawing.Size(196, 31);
            this.IsbnText.TabIndex = 15;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(391, 200);
            this.PriceText.Margin = new System.Windows.Forms.Padding(6);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(196, 31);
            this.PriceText.TabIndex = 16;
            // 
            // QuantityText
            // 
            this.QuantityText.Location = new System.Drawing.Point(391, 246);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(6);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(196, 31);
            this.QuantityText.TabIndex = 17;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(50, 427);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 223);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "The Great Gatsby",
            "To Kill a Mockingbird",
            "Harry Potter"});
            this.comboBox1.Location = new System.Drawing.Point(318, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 1062);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.IsbnText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.TaxText);
            this.Controls.Add(this.Subtotal_Text);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.OrderSummaryLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AddTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTitle;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox Subtotal_Text;
        private System.Windows.Forms.TextBox TaxText;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox IsbnText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
