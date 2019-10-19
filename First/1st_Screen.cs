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
    public partial class _1st_Screen : Form {        

        public _1st_Screen() {
            InitializeComponent();
        }                     

        private void BtnIniciar_Click(object sender, EventArgs e) {
            _2nd_Screen p = new _2nd_Screen();
            p.ShowDialog();
        }

        private void BtnFechar_Click(object sender, EventArgs e) {
            Close();
        }        
    }
}
