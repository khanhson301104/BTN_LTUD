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
    public partial class FRM_BaoCaoChiTietVeLuot : Form
    {
        public FRM_BaoCaoChiTietVeLuot()
        {
            InitializeComponent();
        }
        Coneect_Database kn = new Coneect_Database();

        private void FRM_BaoCaoChiTietVeLuot_Load(object sender, EventArgs e)
        {
            BANGDOANHTHUVELUOT();
        }
        public void BANGDOANHTHUVELUOT()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From vw_BaoCaoDoanhThuVeLuotChiTiet");
            dgv_DoanhThuVeLuot.DataSource = dta;
        }
    }
}
