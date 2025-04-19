namespace BTN_LTUD
{
    partial class FRM_BaoCaoDoanhThuThang
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
            this.dgv_BaoCaoDoanhThuThang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BaoCaoDoanhThuThang
            // 
            this.dgv_BaoCaoDoanhThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaoCaoDoanhThuThang.Location = new System.Drawing.Point(186, 230);
            this.dgv_BaoCaoDoanhThuThang.Name = "dgv_BaoCaoDoanhThuThang";
            this.dgv_BaoCaoDoanhThuThang.RowHeadersWidth = 51;
            this.dgv_BaoCaoDoanhThuThang.RowTemplate.Height = 24;
            this.dgv_BaoCaoDoanhThuThang.Size = new System.Drawing.Size(500, 197);
            this.dgv_BaoCaoDoanhThuThang.TabIndex = 1;
            this.dgv_BaoCaoDoanhThuThang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bao Cao Doanh Thu Theo Ve Thang";
            // 
            // FRM_BaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_BaoCaoDoanhThuThang);
            this.Name = "FRM_BaoCaoDoanhThuThang";
            this.Text = "FRM_BaoCaoDoanhThuThang";
            this.Load += new System.EventHandler(this.FRM_BaoCaoDoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoDoanhThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BaoCaoDoanhThuThang;
        private System.Windows.Forms.Label label1;
    }
}