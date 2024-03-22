﻿namespace SaleManagementWinApp
{
    partial class frmRegister
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
            txtCustomerPassword = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            lbCustomerPassword = new Label();
            lbCustomerEmail = new Label();
            lbCustomerName = new Label();
            lbCustomerId = new Label();
            btCreate = new Button();
            btnCancel = new Button();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Location = new Point(154, 238);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(262, 27);
            txtCustomerPassword.TabIndex = 32;
            txtCustomerPassword.UseSystemPasswordChar = true;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(154, 182);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(262, 27);
            txtCustomerEmail.TabIndex = 31;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(154, 127);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(262, 27);
            txtCustomerName.TabIndex = 30;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(154, 75);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(262, 27);
            txtCustomerId.TabIndex = 29;
            // 
            // lbCustomerPassword
            // 
            lbCustomerPassword.AutoSize = true;
            lbCustomerPassword.Location = new Point(34, 241);
            lbCustomerPassword.Name = "lbCustomerPassword";
            lbCustomerPassword.Size = new Size(70, 20);
            lbCustomerPassword.TabIndex = 25;
            lbCustomerPassword.Text = "Mật khẩu";
            // 
            // lbCustomerEmail
            // 
            lbCustomerEmail.AutoSize = true;
            lbCustomerEmail.Location = new Point(34, 185);
            lbCustomerEmail.Name = "lbCustomerEmail";
            lbCustomerEmail.Size = new Size(49, 20);
            lbCustomerEmail.TabIndex = 24;
            lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(34, 130);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(73, 20);
            lbCustomerName.TabIndex = 23;
            lbCustomerName.Text = "Họ và tên";
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(34, 75);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(22, 20);
            lbCustomerId.TabIndex = 22;
            lbCustomerId.Text = "Id";
            // 
            // btCreate
            // 
            btCreate.Location = new Point(154, 355);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(150, 29);
            btCreate.TabIndex = 38;
            btCreate.Text = "Tạo tài khoản";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(322, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(34, 301);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(97, 20);
            lblPhoneNumber.TabIndex = 40;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(154, 298);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(262, 27);
            txtPhoneNumber.TabIndex = 41;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 404);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(btnCancel);
            Controls.Add(btCreate);
            Controls.Add(txtCustomerPassword);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lbCustomerPassword);
            Controls.Add(lbCustomerEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerId);
            Name = "frmRegister";
            Text = "Add new customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCustomerPassword;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Label lbCustomerPassword;
        private Label lbCustomerEmail;
        private Label lbCustomerName;
        private Label lbCustomerId;
        private Button btCreate;
        private Button btnCancel;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
    }
}