using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_LTUD
{
    public partial class FRM_MonthlySupcription : Form
    {
        public FRM_MonthlySupcription()
        {
            InitializeComponent();
        }
        Coneect_Database kn = new Coneect_Database();

        private void FRM_MonthlySupcription_Load(object sender, EventArgs e)
        {
            BANGVETHANG();
            DANHMUCLOAIXE();
            //DANHMUCPHI();
            VITRIDOXE();
            cbo_LOAIXE.SelectedIndexChanged += cbo_LOAIXE_SelectedIndexChanged;
        }

        public void BANGVETHANG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from MonthlySubscriptions");
            dgv_VETHANG.DataSource = dta;
        }
        public void DANHMUCLOAIXE()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from FeeRates");
            cbo_LOAIXE.DataSource = dta;
            cbo_LOAIXE.DisplayMember = "VehicleType";
        }

        //public void DANHMUCPHI()
        //{
        //    DataTable dta = new DataTable();
        //    dta = kn.Lay_DulieuBang("Select * from FeeRates");
        //    cbo_FEERATES.DataSource = dta;
        //    cbo_FEERATES.DisplayMember = "MonthlyRate";
        //}

        public void VITRIDOXE()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from ParkingLot");
            cbo_LOT.DataSource = dta;
            cbo_LOT.DisplayMember = "LotID";
        }

        private void btn_TAOMOI_Click(object sender, EventArgs e)
        {
            txt_BIENSOXE.Clear();
            cbo_LOAIXE.SelectedIndex = -1;
            txt_FEERATES.Text = "";
            cbo_LOT.SelectedIndex = -1;
            dtp_START.Value = DateTime.Now;
            dtp_END.Value = DateTime.Now.AddMonths(1);
        }

        private void cbo_LOAIXE_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiXe = cbo_LOAIXE.Text.Trim();

            if (loaiXe == "Motorcycle")
            {
                txt_FEERATES.Text = "500000";
            }
            else if (loaiXe == "Car")
            {
                txt_FEERATES.Text = "1000000";
            }
            else
            {
                txt_FEERATES.Text = "";
            }
        }



        private void btn_LUU_Click(object sender, EventArgs e)
        {
            try
            {
                string bienSoXe = txt_BIENSOXE.Text.Trim();
                string loaiXe = cbo_LOAIXE.Text.Trim();
                DateTime startDate = dtp_START.Value.Date;
                DateTime endDate = dtp_END.Value.Date;

                decimal monthlyFee = Convert.ToDecimal(txt_FEERATES.Text);

                int? lotID = null;

                if (cbo_LOT.SelectedItem != null)
                {
                    DataRowView selectedLot = (DataRowView)cbo_LOT.SelectedItem;
                    lotID = Convert.ToInt32(selectedLot["LotID"]);
                }

                if (string.IsNullOrEmpty(bienSoXe) || string.IsNullOrEmpty(loaiXe))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(kn.ChuoiKetNoi)) // chuỗi kết nối từ lớp Coneect_Database
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddMonthlySubscription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@LicensePlate", bienSoXe);
                        cmd.Parameters.AddWithValue("@VehicleType", loaiXe);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        cmd.Parameters.AddWithValue("@MonthlyFee", monthlyFee);
                        cmd.Parameters.AddWithValue("@LotID", lotID != null ? (object)lotID : DBNull.Value);


                        object result = cmd.ExecuteScalar(); // lấy SubscriptionID nếu cần
                        MessageBox.Show("Đăng ký vé tháng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                BANGVETHANG(); // Refresh bảng sau khi lưu
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
