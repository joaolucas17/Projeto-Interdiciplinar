using System;
using System.Windows.Forms;

namespace First {
    public partial class _4th_Screen : Form {

        public _4th_Screen() {
            InitializeComponent();
        }              

        private void Label13_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e) {
            try {
                WebServiceCorreio.AtendeClienteClient consulta = new
                    WebServiceCorreio.AtendeClienteClient("AtendeClientePort");
                var result = consulta.consultaCEP(txbCEP.Text);

                if(result != null) {
                    txbCidade.Text = result.cidade;
                    txbBairro.Text = result.bairro;
                    txbUF.Text = result.uf;
                    txbRua.Text = result.end;
                }
            }
            catch (Exception) {
                MessageBox.Show("CEP inválido!", "Erro");
            }
        }        

        private void BtnLimpar_Click(object sender, EventArgs e) {
            txbNome.Text = null;
            txbCPF.Text = null;
            txbRG.Text = null;
            txbTel.Text = null;
            txbEmail.Text = null;
            txbCEP.Text = null;
            txbCidade.Text = null;
            txbUF.Text = null;
            txbBairro.Text = null;
            txbNum.Text = null;
            txbRua.Text = null;
        }
    }
}
