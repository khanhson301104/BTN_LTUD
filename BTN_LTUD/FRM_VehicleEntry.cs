using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BTN_LTUD
{
    public partial class FRM_VehicleEntry : Form
    {
        public FRM_VehicleEntry()
        {
            InitializeComponent();
        }

        Coneect_Database kn = new Coneect_Database();

        private void FRM_VehicleEntry_Load(object sender, EventArgs e)
        {
            BangBaiDoXe();
            DanhMucPhuongTien();
            BaiXe();
        }

        public void BangBaiDoXe()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from vw_VehiclesInParkingLot");
            dgv_THEMXE.DataSource = dta;
        }

        public void DanhMucPhuongTien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from FeeRates");
            cbo_LOAIPHUONGTIEN.DataSource = dta;
            cbo_LOAIPHUONGTIEN.DisplayMember = "VehicleType";
        }
        public void BaiXe()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from ParkingLot");
            cbo_BAIXE.DataSource = dta;
            cbo_BAIXE.DisplayMember = "LotID";
        }

        private void btn_THEMXE_Click(object sender, EventArgs e)
        {
            try
            {
                kn.KetNoi_DuLieu(); // mở kết nối từ lớp Connect_Database

                kn.cmd = new SqlCommand("sp_VehicleEntry", kn.cnn);
                kn.cmd.CommandType = CommandType.StoredProcedure;

                // Gán tham số cho stored procedure
                kn.cmd.Parameters.AddWithValue("@LicensePlate", txt_BIENSOXE.Text.Trim());
                kn.cmd.Parameters.AddWithValue("@VehicleType", cbo_LOAIPHUONGTIEN.Text.Trim());
                kn.cmd.Parameters.AddWithValue("@LotID", cbo_BAIXE.Text.Trim());

                // Thực thi stored procedure
                int result = kn.cmd.ExecuteNonQuery();
                kn.HuyKetNoi(); // đóng kết nối

                if (result > 0)
                {
                    MessageBox.Show("Thêm xe thành công!");
                    BangBaiDoXe(); // refresh lại bảng
                }
                else
                {
                    MessageBox.Show("Không thêm được xe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
