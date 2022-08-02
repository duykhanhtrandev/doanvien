using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageLayer;

namespace QLDOANVIEN
{
    public partial class formTest : DevExpress.XtraEditors.XtraForm
    {
        public formTest()
        {
            InitializeComponent();
        }

        private void formTest_Load(object sender, EventArgs e)
        {
            TRINHDO tb = new TRINHDO();
            gridControl1.DataSource = tb.getList();
        }
    }
}