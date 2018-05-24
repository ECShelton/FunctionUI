namespace FunctionUI
{
    partial class Terminal
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
            this.lbl_Modifyer = new System.Windows.Forms.Label();
            this.pb_execute = new System.Windows.Forms.ProgressBar();
            this.lbl_execute = new System.Windows.Forms.Label();
            this.txt_terminal = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // lbl_Modifyer
            // 
            this.lbl_Modifyer.AutoSize = true;
            this.lbl_Modifyer.Location = new System.Drawing.Point(13, 459);
            this.lbl_Modifyer.Name = "lbl_Modifyer";
            this.lbl_Modifyer.Size = new System.Drawing.Size(0, 17);
            this.lbl_Modifyer.TabIndex = 0;
            // 
            // pb_execute
            // 
            this.pb_execute.Location = new System.Drawing.Point(157, 457);
            this.pb_execute.Name = "pb_execute";
            this.pb_execute.Size = new System.Drawing.Size(230, 23);
            this.pb_execute.TabIndex = 1;
            // 
            // lbl_execute
            // 
            this.lbl_execute.AutoSize = true;
            this.lbl_execute.Location = new System.Drawing.Point(394, 459);
            this.lbl_execute.Name = "lbl_execute";
            this.lbl_execute.Size = new System.Drawing.Size(49, 17);
            this.lbl_execute.TabIndex = 2;
            this.lbl_execute.Text = "Ready";
            // 
            // txt_terminal
            // 
            this.txt_terminal.Location = new System.Drawing.Point(16, 12);
            this.txt_terminal.Multiline = true;
            this.txt_terminal.Name = "txt_terminal";
            this.txt_terminal.ShortcutsEnabled = false;
            this.txt_terminal.Size = new System.Drawing.Size(735, 427);
            this.txt_terminal.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(758, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 427);
            this.vScrollBar1.TabIndex = 4;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 488);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.txt_terminal);
            this.Controls.Add(this.lbl_execute);
            this.Controls.Add(this.pb_execute);
            this.Controls.Add(this.lbl_Modifyer);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Modifyer;
        private System.Windows.Forms.ProgressBar pb_execute;
        private System.Windows.Forms.Label lbl_execute;
        private System.Windows.Forms.TextBox txt_terminal;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}