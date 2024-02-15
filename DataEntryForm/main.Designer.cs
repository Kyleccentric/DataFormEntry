namespace DataEntryForm
{
    partial class main
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
            this.button_insert = new System.Windows.Forms.Button();
            this.DataFormTable = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_createreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataFormTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(65, 77);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(119, 46);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataFormTable
            // 
            this.DataFormTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFormTable.Location = new System.Drawing.Point(226, 77);
            this.DataFormTable.Name = "DataFormTable";
            this.DataFormTable.Size = new System.Drawing.Size(470, 340);
            this.DataFormTable.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(65, 168);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(119, 46);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(65, 259);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(119, 46);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(460, 51);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(173, 20);
            this.txt_search.TabIndex = 4;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(639, 51);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(63, 20);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_createreport
            // 
            this.button_createreport.Location = new System.Drawing.Point(591, 428);
            this.button_createreport.Name = "button_createreport";
            this.button_createreport.Size = new System.Drawing.Size(105, 23);
            this.button_createreport.TabIndex = 6;
            this.button_createreport.Text = "Create Report";
            this.button_createreport.UseVisualStyleBackColor = true;
            this.button_createreport.Click += new System.EventHandler(this.button_report_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 463);
            this.Controls.Add(this.button_createreport);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.DataFormTable);
            this.Controls.Add(this.button_insert);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.DataFormTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.DataGridView DataFormTable;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_createreport;
    }
}