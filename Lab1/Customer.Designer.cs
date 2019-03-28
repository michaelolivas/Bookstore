
using System;

namespace Lab1
{
    partial class Customer
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(44, 41);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(356, 32);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1005, 274);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 41);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1005, 188);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 41);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(913, 109);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(215, 41);
            this.newCustomerButton.TabIndex = 3;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1005, 42);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 41);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zip Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email:";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(169, 123);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(231, 29);
            this.firstTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(169, 185);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(796, 29);
            this.addressTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(169, 250);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(305, 29);
            this.cityTextBox.TabIndex = 16;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(169, 321);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(231, 29);
            this.PhoneTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(169, 405);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(305, 29);
            this.emailTextBox.TabIndex = 18;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Location = new System.Drawing.Point(564, 123);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(241, 29);
            this.lastTextBox.TabIndex = 19;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(565, 252);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(159, 29);
            this.stateTextBox.TabIndex = 20;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(865, 252);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 29);
            this.zipTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(630, 401);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(498, 29);
            this.statusTextBox.TabIndex = 23;
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // CustomerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 570);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.lastTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.comboBox);
            this.Name = "CustomerPortal";
            this.Text = "CustomerPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}
