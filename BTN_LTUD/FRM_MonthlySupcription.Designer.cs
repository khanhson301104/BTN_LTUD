namespace BTN_LTUD
{
    partial class FRM_MonthlySupcription
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BIENSOXE = new System.Windows.Forms.TextBox();
            this.btn_TAOMOI = new System.Windows.Forms.Button();
            this.btn_LUU = new System.Windows.Forms.Button();
            this.cbo_LOAIXE = new System.Windows.Forms.ComboBox();
            this.dtp_START = new System.Windows.Forms.DateTimePicker();
            this.dtp_END = new System.Windows.Forms.DateTimePicker();
            this.cbo_LOT = new System.Windows.Forms.ComboBox();
            this.dgv_VETHANG = new System.Windows.Forms.DataGridView();
            this.txt_FEERATES = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VETHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển Số Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phí Hàng Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vị Trí Đỗ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "End Date";
            // 
            // txt_BIENSOXE
            // 
            this.txt_BIENSOXE.Location = new System.Drawing.Point(219, 76);
            this.txt_BIENSOXE.Name = "txt_BIENSOXE";
            this.txt_BIENSOXE.Size = new System.Drawing.Size(121, 22);
            this.txt_BIENSOXE.TabIndex = 6;
            // 
            // btn_TAOMOI
            // 
            this.btn_TAOMOI.Location = new System.Drawing.Point(765, 79);
            this.btn_TAOMOI.Name = "btn_TAOMOI";
            this.btn_TAOMOI.Size = new System.Drawing.Size(117, 43);
            this.btn_TAOMOI.TabIndex = 12;
            this.btn_TAOMOI.Text = "Tạo Mới";
            this.btn_TAOMOI.UseVisualStyleBackColor = true;
            this.btn_TAOMOI.Click += new System.EventHandler(this.btn_TAOMOI_Click);
            // 
            // btn_LUU
            // 
            this.btn_LUU.Location = new System.Drawing.Point(765, 172);
            this.btn_LUU.Name = "btn_LUU";
            this.btn_LUU.Size = new System.Drawing.Size(117, 38);
            this.btn_LUU.TabIndex = 13;
            this.btn_LUU.Text = "Lưu";
            this.btn_LUU.UseVisualStyleBackColor = true;
            this.btn_LUU.Click += new System.EventHandler(this.btn_LUU_Click);
            // 
            // cbo_LOAIXE
            // 
            this.cbo_LOAIXE.FormattingEnabled = true;
            this.cbo_LOAIXE.Location = new System.Drawing.Point(219, 141);
            this.cbo_LOAIXE.Name = "cbo_LOAIXE";
            this.cbo_LOAIXE.Size = new System.Drawing.Size(121, 24);
            this.cbo_LOAIXE.TabIndex = 14;
            this.cbo_LOAIXE.SelectedIndexChanged += new System.EventHandler(this.cbo_LOAIXE_SelectedIndexChanged);
            // 
            // dtp_START
            // 
            this.dtp_START.Location = new System.Drawing.Point(449, 79);
            this.dtp_START.Name = "dtp_START";
            this.dtp_START.Size = new System.Drawing.Size(238, 22);
            this.dtp_START.TabIndex = 16;
            // 
            // dtp_END
            // 
            this.dtp_END.Location = new System.Drawing.Point(449, 143);
            this.dtp_END.Name = "dtp_END";
            this.dtp_END.Size = new System.Drawing.Size(238, 22);
            this.dtp_END.TabIndex = 17;
            // 
            // cbo_LOT
            // 
            this.cbo_LOT.FormattingEnabled = true;
            this.cbo_LOT.Location = new System.Drawing.Point(449, 200);
            this.cbo_LOT.Name = "cbo_LOT";
            this.cbo_LOT.Size = new System.Drawing.Size(121, 24);
            this.cbo_LOT.TabIndex = 18;
            // 
            // dgv_VETHANG
            // 
            this.dgv_VETHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VETHANG.Location = new System.Drawing.Point(219, 294);
            this.dgv_VETHANG.Name = "dgv_VETHANG";
            this.dgv_VETHANG.RowHeadersWidth = 51;
            this.dgv_VETHANG.RowTemplate.Height = 24;
            this.dgv_VETHANG.Size = new System.Drawing.Size(663, 171);
            this.dgv_VETHANG.TabIndex = 19;
            // 
            // txt_FEERATES
            // 
            this.txt_FEERATES.Location = new System.Drawing.Point(219, 208);
            this.txt_FEERATES.Name = "txt_FEERATES";
            this.txt_FEERATES.Size = new System.Drawing.Size(121, 22);
            this.txt_FEERATES.TabIndex = 20;
            // 
            // FRM_MonthlySupcription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 495);
            this.Controls.Add(this.txt_FEERATES);
            this.Controls.Add(this.dgv_VETHANG);
            this.Controls.Add(this.cbo_LOT);
            this.Controls.Add(this.dtp_END);
            this.Controls.Add(this.dtp_START);
            this.Controls.Add(this.cbo_LOAIXE);
            this.Controls.Add(this.btn_LUU);
            this.Controls.Add(this.btn_TAOMOI);
            this.Controls.Add(this.txt_BIENSOXE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_MonthlySupcription";
            this.Text = "FRM_MonthlySupcription";
            this.Load += new System.EventHandler(this.FRM_MonthlySupcription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VETHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BIENSOXE;
        private System.Windows.Forms.Button btn_TAOMOI;
        private System.Windows.Forms.Button btn_LUU;
        private System.Windows.Forms.ComboBox cbo_LOAIXE;
        private System.Windows.Forms.DateTimePicker dtp_START;
        private System.Windows.Forms.DateTimePicker dtp_END;
        private System.Windows.Forms.ComboBox cbo_LOT;
        private System.Windows.Forms.DataGridView dgv_VETHANG;
        private System.Windows.Forms.TextBox txt_FEERATES;
    }
}