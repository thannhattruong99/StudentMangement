namespace WindowsFormsApp1
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
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.cbb_StudentCode = new System.Windows.Forms.ComboBox();
            this.txt_StudentInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View
            // 
            this.dgv_View.ColumnHeadersHeight = 46;
            this.dgv_View.Location = new System.Drawing.Point(59, 187);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.RowHeadersWidth = 82;
            this.dgv_View.RowTemplate.Height = 33;
            this.dgv_View.Size = new System.Drawing.Size(1252, 477);
            this.dgv_View.TabIndex = 1;
            this.dgv_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_View_CellContentClick);
            this.dgv_View.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_View_CellContentClick);
            // 
            // cbb_StudentCode
            // 
            this.cbb_StudentCode.FormattingEnabled = true;
            this.cbb_StudentCode.Location = new System.Drawing.Point(79, 68);
            this.cbb_StudentCode.Name = "cbb_StudentCode";
            this.cbb_StudentCode.Size = new System.Drawing.Size(303, 33);
            this.cbb_StudentCode.TabIndex = 2;
            this.cbb_StudentCode.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSV_SelectedIndexChanged);
            // 
            // txt_StudentInfo
            // 
            this.txt_StudentInfo.Location = new System.Drawing.Point(513, 68);
            this.txt_StudentInfo.Name = "txt_StudentInfo";
            this.txt_StudentInfo.Size = new System.Drawing.Size(741, 31);
            this.txt_StudentInfo.TabIndex = 3;
            this.txt_StudentInfo.TextChanged += new System.EventHandler(this.txt_ThongTinSV_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 920);
            this.Controls.Add(this.txt_StudentInfo);
            this.Controls.Add(this.cbb_StudentCode);
            this.Controls.Add(this.dgv_View);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.ComboBox cbb_StudentCode;
        private System.Windows.Forms.TextBox txt_StudentInfo;
    }
}

