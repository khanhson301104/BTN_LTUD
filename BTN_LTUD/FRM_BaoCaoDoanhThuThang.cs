using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_LTUD
{
    public partial class FRM_BaoCaoDoanhThuThang : Form
    {
        public FRM_BaoCaoDoanhThuThang()
        {
            InitializeComponent();
        }
        Coneect_Database kn = new Coneect_Database();


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_BaoCaoDoanhThuThang_Load(object sender, EventArgs e)
        {
            BANGDOANHTHUTHANG();
        }
        public void BANGDOANHTHUTHANG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from vw_BaoCaoDangKyThang");
            dgv_BaoCaoDoanhThuThang.DataSource = dta;
        }
    }
}
