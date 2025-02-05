﻿namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.grd_contacts = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(97, 7);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(132, 22);
            this.txt_firstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(321, 7);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(132, 22);
            this.txt_lastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(575, 7);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txt_phoneNumber.TabIndex = 5;
            // 
            // grd_contacts
            // 
            this.grd_contacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_contacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.FirstName,
            this.LastName,
            this.PhoneNumber});
            this.grd_contacts.Location = new System.Drawing.Point(20, 75);
            this.grd_contacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd_contacts.Name = "grd_contacts";
            this.grd_contacts.ReadOnly = true;
            this.grd_contacts.RowHeadersWidth = 51;
            this.grd_contacts.Size = new System.Drawing.Size(824, 254);
            this.grd_contacts.TabIndex = 7;
            this.grd_contacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_contacts_CellContentClick);
            // 
            // ContactId
            // 
            this.ContactId.HeaderText = "Id";
            this.ContactId.MinimumWidth = 6;
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(153, 39);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 28);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(286, 39);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(125, 28);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 384);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.grd_contacts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_contacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.DataGridView grd_contacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
    }
}

