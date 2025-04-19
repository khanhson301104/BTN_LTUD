namespace BTN_LTUD
{
    partial class FRM_VehicleEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BIENSOXE = new System.Windows.Forms.TextBox();
            this.cbo_LOAIPHUONGTIEN = new System.Windows.Forms.ComboBox();
            this.cbo_BAIXE = new System.Windows.Forms.ComboBox();
            this.btn_THEMXE = new System.Windows.Forms.Button();
            this.dgv_THEMXE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_THEMXE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phương tiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bãi xe";
            // 
            // txt_BIENSOXE
            // 
            this.txt_BIENSOXE.Location = new System.Drawing.Point(271, 113);
            this.txt_BIENSOXE.Name = "txt_BIENSOXE";
            this.txt_BIENSOXE.Size = new System.Drawing.Size(132, 22);
            this.txt_BIENSOXE.TabIndex = 3;
            // 
            // cbo_LOAIPHUONGTIEN
            // 
            this.cbo_LOAIPHUONGTIEN.FormattingEnabled = true;
            this.cbo_LOAIPHUONGTIEN.Location = new System.Drawing.Point(271, 201);
            this.cbo_LOAIPHUONGTIEN.Name = "cbo_LOAIPHUONGTIEN";
            this.cbo_LOAIPHUONGTIEN.Size = new System.Drawing.Size(132, 24);
            this.cbo_LOAIPHUONGTIEN.TabIndex = 4;
            // 
            // cbo_BAIXE
            // 
            this.cbo_BAIXE.FormattingEnabled = true;
            this.cbo_BAIXE.Location = new System.Drawing.Point(271, 278);
            this.cbo_BAIXE.Name = "cbo_BAIXE";
            this.cbo_BAIXE.Size = new System.Drawing.Size(132, 24);
            this.cbo_BAIXE.TabIndex = 5;
            // 
            // btn_THEMXE
            // 
            this.btn_THEMXE.Location = new System.Drawing.Point(723, 137);
            this.btn_THEMXE.Name = "btn_THEMXE";
            this.btn_THEMXE.Size = new System.Drawing.Size(169, 58);
            this.btn_THEMXE.TabIndex = 6;
            this.btn_THEMXE.Text = "Thêm xe";
            this.btn_THEMXE.UseVisualStyleBackColor = true;
            this.btn_THEMXE.Click += new System.EventHandler(this.btn_THEMXE_Click);
            // 
            // dgv_THEMXE
            // 
            this.dgv_THEMXE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_THEMXE.Location = new System.Drawing.Point(115, 371);
            this.dgv_THEMXE.Name = "dgv_THEMXE";
            this.dgv_THEMXE.RowHeadersWidth = 51;
            this.dgv_THEMXE.RowTemplate.Height = 24;
            this.dgv_THEMXE.Size = new System.Drawing.Size(866, 219);
            this.dgv_THEMXE.TabIndex = 7;
            // 
            // FRM_VehicleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 632);
            this.Controls.Add(this.dgv_THEMXE);
            this.Controls.Add(this.btn_THEMXE);
            this.Controls.Add(this.cbo_BAIXE);
            this.Controls.Add(this.cbo_LOAIPHUONGTIEN);
            this.Controls.Add(this.txt_BIENSOXE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_VehicleEntry";
            this.Text = "FRM_VehicleEntry";
            this.Load += new System.EventHandler(this.FRM_VehicleEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_THEMXE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BIENSOXE;
        private System.Windows.Forms.ComboBox cbo_LOAIPHUONGTIEN;
        private System.Windows.Forms.ComboBox cbo_BAIXE;
        private System.Windows.Forms.Button btn_THEMXE;
        private System.Windows.Forms.DataGridView dgv_THEMXE;
    }
}