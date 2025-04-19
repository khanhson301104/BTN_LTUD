namespace BTN_LTUD
{
    partial class FRM_BaoCaoChiTietVeLuot
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
            this.dgv_DoanhThuVeLuot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuVeLuot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DoanhThuVeLuot
            // 
            this.dgv_DoanhThuVeLuot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThuVeLuot.Location = new System.Drawing.Point(200, 194);
            this.dgv_DoanhThuVeLuot.Name = "dgv_DoanhThuVeLuot";
            this.dgv_DoanhThuVeLuot.RowHeadersWidth = 51;
            this.dgv_DoanhThuVeLuot.RowTemplate.Height = 24;
            this.dgv_DoanhThuVeLuot.Size = new System.Drawing.Size(575, 236);
            this.dgv_DoanhThuVeLuot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bao Cao Doanh Thu Ve Luot";
            // 
            // FRM_BaoCaoChiTietVeLuot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DoanhThuVeLuot);
            this.Name = "FRM_BaoCaoChiTietVeLuot";
            this.Text = "FRM_BAOCAOCHITIETVELUOT";
            this.Load += new System.EventHandler(this.FRM_BaoCaoChiTietVeLuot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuVeLuot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DoanhThuVeLuot;
        private System.Windows.Forms.Label label1;
    }
}