using System;

namespace FunctionUI
{
    partial class LoginForm
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.lbl_err = new System.Windows.Forms.Label();
            this.txt_psswd = new FunctionUI.QuietTextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(35, 151);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.Location = new System.Drawing.Point(35, 180);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(100, 23);
            this.btn_Guest.TabIndex = 1;
            this.btn_Guest.Text = "Guest Login";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // txt_usrname
            // 
            this.txt_usrname.Location = new System.Drawing.Point(35, 56);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.ShortcutsEnabled = false;
            this.txt_usrname.Size = new System.Drawing.Size(100, 22);
            this.txt_usrname.TabIndex = 2;
            this.txt_usrname.Text = "username";
            this.txt_usrname.Enter += new System.EventHandler(this.txt_usrname_Enter);
            this.txt_usrname.GotFocus += new System.EventHandler(this.txt_usrname_Caps);
            this.txt_usrname.Leave += new System.EventHandler(this.txt_usrname_Leave);
            this.txt_usrname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_usrname_PreviewKeyDown);
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Location = new System.Drawing.Point(35, 125);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(0, 17);
            this.lbl_err.TabIndex = 4;
            // 
            // txt_psswd
            // 
            this.txt_psswd.Location = new System.Drawing.Point(35, 98);
            this.txt_psswd.Name = "txt_psswd";
            this.txt_psswd.Size = new System.Drawing.Size(100, 22);
            this.txt_psswd.TabIndex = 3;
            this.txt_psswd.Text = "password";
            this.txt_psswd.Enter += new System.EventHandler(this.txt_psswd_Enter);
            this.txt_psswd.GotFocus += new System.EventHandler(this.txt_psswd_Caps);
            this.txt_psswd.Leave += new System.EventHandler(this.txt_psswd_Leave);
            this.txt_psswd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_psswd_PreviewKeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 234);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.txt_psswd);
            this.Controls.Add(this.txt_usrname);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.TextBox txt_usrname;
        private QuietTextBox txt_psswd;
        private System.Windows.Forms.Label lbl_err;
    }
}

