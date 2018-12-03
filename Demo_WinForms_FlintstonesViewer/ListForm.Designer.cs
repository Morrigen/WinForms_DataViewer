namespace WinForms_DataViewer
{
    partial class ListForm
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
            this.dataGridView_Characters = new System.Windows.Forms.DataGridView();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.btn_DetailView = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_sort2 = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Characters
            // 
            this.dataGridView_Characters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Characters.Location = new System.Drawing.Point(26, 41);
            this.dataGridView_Characters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_Characters.Name = "dataGridView_Characters";
            this.dataGridView_Characters.RowTemplate.Height = 24;
            this.dataGridView_Characters.Size = new System.Drawing.Size(611, 286);
            this.dataGridView_Characters.TabIndex = 0;
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.Location = new System.Drawing.Point(485, 333);
            this.btn_DeleteSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(149, 28);
            this.btn_DeleteSelected.TabIndex = 1;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = true;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_CheckList_Click);
            // 
            // btn_DetailView
            // 
            this.btn_DetailView.Location = new System.Drawing.Point(26, 333);
            this.btn_DetailView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DetailView.Name = "btn_DetailView";
            this.btn_DetailView.Size = new System.Drawing.Size(149, 28);
            this.btn_DetailView.TabIndex = 2;
            this.btn_DetailView.Text = "View Detail";
            this.btn_DetailView.UseVisualStyleBackColor = true;
            this.btn_DetailView.Click += new System.EventHandler(this.btn_DetailView_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(21, 6);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(129, 29);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Characters";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(590, 6);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(47, 28);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(179, 333);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(149, 28);
            this.btn_sort.TabIndex = 5;
            this.btn_sort.Text = "Sort By Age";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_sort2
            // 
            this.btn_sort2.Location = new System.Drawing.Point(332, 333);
            this.btn_sort2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sort2.Name = "btn_sort2";
            this.btn_sort2.Size = new System.Drawing.Size(149, 28);
            this.btn_sort2.TabIndex = 6;
            this.btn_sort2.Text = "Sort By Name";
            this.btn_sort2.UseVisualStyleBackColor = true;
            this.btn_sort2.Click += new System.EventHandler(this.btn_sort2_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(539, 6);
            this.btn_help.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(47, 28);
            this.btn_help.TabIndex = 7;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 375);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_sort2);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_DetailView);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.dataGridView_Characters);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ListForm";
            this.Text = "Cartoon Characters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Characters;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Button btn_DetailView;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_sort2;
        private System.Windows.Forms.Button btn_help;
    }
}

