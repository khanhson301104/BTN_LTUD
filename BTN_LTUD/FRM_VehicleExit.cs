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
    public partial class FRM_VehicleExit : Form
    {
        public FRM_VehicleExit()
        {
            InitializeComponent();
        }

        Coneect_Database kn = new Coneect_Database();

        private void FRM_VehicleExit_Load(object sender, EventArgs e)
        {
            BangBaiDoXe();
        }

        private void btn_XERA_Click(object sender, EventArgs e)
        {
            try
            {
                kn.KetNoi_DuLieu();

                if (rad_VELUOT.Checked) // Vé lượt
                {
                    kn.cmd = new SqlCommand("sp_VehicleExit", kn.cnn);
                    kn.cmd.CommandType = CommandType.StoredProcedure;

                    kn.cmd.Parameters.AddWithValue("@LicensePlate", txt_BIENSOXE.Text.Trim());

                    if (chk_MATMAVE.Checked)
                    {
                        kn.cmd.Parameters.AddWithValue("@TicketCode", DBNull.Value); // NULL khi mất vé
                        kn.cmd.Parameters.AddWithValue("@IsLost", 1);
                    }
                    else
                    {
                        // Nếu không mất vé, tự động lấy mã vé nếu chưa có
                        if (string.IsNullOrWhiteSpace(txt_MAVE.Text))
                        {
                            string ticketCode = LayMaVeHieuLuc(txt_BIENSOXE.Text.Trim());

                            if (string.IsNullOrEmpty(ticketCode))
                            {
                                MessageBox.Show("Không tìm thấy mã vé hợp lệ cho xe này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            txt_MAVE.Text = ticketCode;
                        }

                        kn.cmd.Parameters.AddWithValue("@TicketCode", txt_MAVE.Text.Trim());
                        kn.cmd.Parameters.AddWithValue("@IsLost", 0);
                    }

                    SqlDataReader reader = kn.cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader["Message"].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                else if (rad_VETHANG.Checked) // Vé tháng
                {
                    kn.cmd = new SqlCommand("sp_MonthlyVehicleExit", kn.cnn);
                    kn.cmd.CommandType = CommandType.StoredProcedure;

                    kn.cmd.Parameters.AddWithValue("@LicensePlate", txt_BIENSOXE.Text.Trim());

                    SqlDataReader reader = kn.cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader["Message"].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                kn.HuyKetNoi();

                // Gọi lại hàm load lại bảng nếu có
                BangBaiDoXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BangBaiDoXe()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from vw_VehiclesInParkingLot");
            dgv_XERA.DataSource = dta;
        }

        // ✅ Hàm lấy mã vé còn hiệu lực từ biển số
        private string LayMaVeHieuLuc(string licensePlate)
        {
            string ticketCode = null;

            try
            {
                kn.KetNoi_DuLieu();

                SqlCommand cmd = new SqlCommand(@"
                    SELECT TOP 1 TicketCode 
                    FROM ParkingTickets 
                    WHERE LicensePlate = @LicensePlate AND IsValid = 1 AND IsOut = 0
                    ORDER BY EntryTime DESC", kn.cnn);

                cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ticketCode = result.ToString();
                }

                kn.HuyKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ticketCode;
        }

        // ✅ Tự động điền mã vé khi người dùng nhập biển số và không mất vé
        private void txt_BIENSOXE_Leave(object sender, EventArgs e)
        {
            if (rad_VELUOT.Checked && !chk_MATMAVE.Checked)
            {
                string licensePlate = txt_BIENSOXE.Text.Trim();
                string ticketCode = LayMaVeHieuLuc(licensePlate);

                if (!string.IsNullOrEmpty(ticketCode))
                {
                    txt_MAVE.Text = ticketCode;
                }
            }
        }

        // ✅ Nếu tick "Mất vé" thì xóa mã vé và disable nhập
        private void chk_MATMAVE_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MATMAVE.Checked)
            {
                txt_MAVE.Text = "";
                txt_MAVE.Enabled = false;
            }
            else
            {
                txt_MAVE.Enabled = true;
            }
        }
    }
}
