namespace BTN_LTUD
{
    partial class FRM_VehicleExit
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
            this.txt_BIENSOXE = new System.Windows.Forms.TextBox();
            this.txt_MAVE = new System.Windows.Forms.TextBox();
            this.btn_XERA = new System.Windows.Forms.Button();
            this.rad_VELUOT = new System.Windows.Forms.RadioButton();
            this.rad_VETHANG = new System.Windows.Forms.RadioButton();
            this.chk_MATMAVE = new System.Windows.Forms.CheckBox();
            this.dgv_XERA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XERA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển Số Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket Code";
            // 
            // txt_BIENSOXE
            // 
            this.txt_BIENSOXE.Location = new System.Drawing.Point(219, 78);
            this.txt_BIENSOXE.Name = "txt_BIENSOXE";
            this.txt_BIENSOXE.Size = new System.Drawing.Size(100, 22);
            this.txt_BIENSOXE.TabIndex = 3;
            this.txt_BIENSOXE.Leave += new System.EventHandler(this.txt_BIENSOXE_Leave);
            // 
            // txt_MAVE
            // 
            this.txt_MAVE.Location = new System.Drawing.Point(219, 144);
            this.txt_MAVE.Name = "txt_MAVE";
            this.txt_MAVE.Size = new System.Drawing.Size(100, 22);
            this.txt_MAVE.TabIndex = 4;
            // 
            // btn_XERA
            // 
            this.btn_XERA.Location = new System.Drawing.Point(655, 127);
            this.btn_XERA.Name = "btn_XERA";
            this.btn_XERA.Size = new System.Drawing.Size(143, 43);
            this.btn_XERA.TabIndex = 7;
            this.btn_XERA.Text = "Xoa Xe";
            this.btn_XERA.UseVisualStyleBackColor = true;
            this.btn_XERA.Click += new System.EventHandler(this.btn_XERA_Click);
            // 
            // rad_VELUOT
            // 
            this.rad_VELUOT.AutoSize = true;
            this.rad_VELUOT.Location = new System.Drawing.Point(396, 79);
            this.rad_VELUOT.Name = "rad_VELUOT";
            this.rad_VELUOT.Size = new System.Drawing.Size(73, 20);
            this.rad_VELUOT.TabIndex = 8;
            this.rad_VELUOT.TabStop = true;
            this.rad_VELUOT.Text = "Vé Lượt";
            this.rad_VELUOT.UseVisualStyleBackColor = true;
            // 
            // rad_VETHANG
            // 
            this.rad_VETHANG.AutoSize = true;
            this.rad_VETHANG.Location = new System.Drawing.Point(396, 150);
            this.rad_VETHANG.Name = "rad_VETHANG";
            this.rad_VETHANG.Size = new System.Drawing.Size(87, 20);
            this.rad_VETHANG.TabIndex = 9;
            this.rad_VETHANG.TabStop = true;
            this.rad_VETHANG.Text = "Vé Tháng";
            this.rad_VETHANG.UseVisualStyleBackColor = true;
            // 
            // chk_MATMAVE
            // 
            this.chk_MATMAVE.AutoSize = true;
            this.chk_MATMAVE.Location = new System.Drawing.Point(655, 78);
            this.chk_MATMAVE.Name = "chk_MATMAVE";
            this.chk_MATMAVE.Size = new System.Drawing.Size(71, 20);
            this.chk_MATMAVE.TabIndex = 10;
            this.chk_MATMAVE.Text = "Mất Vé";
            this.chk_MATMAVE.UseVisualStyleBackColor = true;
            this.chk_MATMAVE.CheckedChanged += new System.EventHandler(this.chk_MATMAVE_CheckedChanged);
            // 
            // dgv_XERA
            // 
            this.dgv_XERA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XERA.Location = new System.Drawing.Point(181, 249);
            this.dgv_XERA.Name = "dgv_XERA";
            this.dgv_XERA.RowHeadersWidth = 51;
            this.dgv_XERA.RowTemplate.Height = 24;
            this.dgv_XERA.Size = new System.Drawing.Size(534, 189);
            this.dgv_XERA.TabIndex = 11;
            // 
            // FRM_VehicleExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 502);
            this.Controls.Add(this.dgv_XERA);
            this.Controls.Add(this.chk_MATMAVE);
            this.Controls.Add(this.rad_VETHANG);
            this.Controls.Add(this.rad_VELUOT);
            this.Controls.Add(this.btn_XERA);
            this.Controls.Add(this.txt_MAVE);
            this.Controls.Add(this.txt_BIENSOXE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_VehicleExit";
            this.Text = "FRM_Vehicle_Exit";
            this.Load += new System.EventHandler(this.FRM_VehicleExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XERA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BIENSOXE;
        private System.Windows.Forms.TextBox txt_MAVE;
        private System.Windows.Forms.Button btn_XERA;
        private System.Windows.Forms.RadioButton rad_VELUOT;
        private System.Windows.Forms.RadioButton rad_VETHANG;
        private System.Windows.Forms.CheckBox chk_MATMAVE;
        private System.Windows.Forms.DataGridView dgv_XERA;
    }
}