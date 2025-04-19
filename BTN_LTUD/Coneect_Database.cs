using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTN_LTUD
{
    internal class Coneect_Database
    {
        public SqlConnection cnn; // Kết nối dữ liệu
        public SqlCommand cmd; // Thực hiện câu lệnh
        public DataTable dta; // Làm việc với bảng dữ liệu
        public SqlDataAdapter ada; // Làm việc với tập dữ liệu


        string strKetnoi = @"Data Source=LAPTOP-TAIQNRT1;Initial Catalog=QuanLyBaiXe2;Integrated Security=True";
        public void KetNoi_DuLieu()
        {
            string strKetnoi = @"Data Source=LAPTOP-TAIQNRT1;Initial Catalog=QuanLyBaiXe2;Integrated Security=True";
            cnn = new SqlConnection(strKetnoi);
            cnn.Open();
        }
        public string ChuoiKetNoi
        {
            get { return strKetnoi; }
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }

    }
}
