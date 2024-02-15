namespace DataEntryForm
{
    partial class insert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.button_submit = new System.Windows.Forms.Button();
            this.listbox_address = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_deleteAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birthday";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(170, 76);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(195, 20);
            this.txt_firstname.TabIndex = 7;
            // 
            // txt_middlename
            // 
            this.txt_middlename.Location = new System.Drawing.Point(170, 110);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(195, 20);
            this.txt_middlename.TabIndex = 8;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(170, 345);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 9;
            this.txt_age.TextChanged += new System.EventHandler(this.txt_age_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(170, 173);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(195, 20);
            this.txt_address.TabIndex = 10;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(170, 142);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(195, 20);
            this.txt_lastname.TabIndex = 11;
            // 
            // date_birthday
            // 
            this.date_birthday.Location = new System.Drawing.Point(170, 310);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(195, 20);
            this.date_birthday.TabIndex = 12;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(290, 400);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 13;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // listbox_address
            // 
            this.listbox_address.FormattingEnabled = true;
            this.listbox_address.Location = new System.Drawing.Point(170, 199);
            this.listbox_address.Name = "listbox_address";
            this.listbox_address.Size = new System.Drawing.Size(195, 82);
            this.listbox_address.TabIndex = 14;
            this.listbox_address.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_addAddress_Click);
            // 
            // button_deleteAddress
            // 
            this.button_deleteAddress.Location = new System.Drawing.Point(371, 200);
            this.button_deleteAddress.Name = "button_deleteAddress";
            this.button_deleteAddress.Size = new System.Drawing.Size(87, 23);
            this.button_deleteAddress.TabIndex = 16;
            this.button_deleteAddress.Text = "Delete Address";
            this.button_deleteAddress.UseVisualStyleBackColor = true;
            this.button_deleteAddress.Click += new System.EventHandler(this.button_deleteAddress_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.button_deleteAddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox_address);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.date_birthday);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.Click += new System.EventHandler(this.button_submit_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.ListBox listbox_address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_deleteAddress;
    }
}