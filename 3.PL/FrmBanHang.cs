using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void btn_QuetBarCode_Click(object sender, EventArgs e)
        {
            FrmQRCode frmQRCode = new FrmQRCode();
            frmQRCode.Show();
        }
    }
}
