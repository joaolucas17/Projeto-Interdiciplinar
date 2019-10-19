using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First {
    public partial class _2nd_Screen : Form {

        _1st_Screen p = new _1st_Screen();

        public _2nd_Screen() {
            InitializeComponent();            
            p.Close();
        }

        private void _2nd_Screen_Load(object sender, EventArgs e) {

        }

        private void BtnDonation_Click(object sender, EventArgs e) {
            _3rd_screen p = new _3rd_screen();
            p.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
