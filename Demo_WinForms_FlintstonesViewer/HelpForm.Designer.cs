namespace Demo_WinForms_FlintstonesViewer
{
    partial class HelpForm
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
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(116, 68);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(81, 25);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_Help
            // 
            this.lbl_Help.AutoSize = true;
            this.lbl_Help.Location = new System.Drawing.Point(22, 34);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.Size = new System.Drawing.Size(285, 13);
            this.lbl_Help.TabIndex = 6;
            this.lbl_Help.Text = "Click the buttons along the bottom to interact with the data.";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 107);
            this.Controls.Add(this.lbl_Help);
            this.Controls.Add(this.btn_close);
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.Text = "Help Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_Help;
    }
}