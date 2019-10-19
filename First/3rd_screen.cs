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
    public partial class _3rd_screen : Form {

        int idade = 0;
        double peso = 0;        

        public _3rd_screen() {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e) {
            string aux = cmbAnimal.Text.ToUpper();
            string aux2 = cmbPorte.Text.ToUpper();
            string aux3 = cmbDef.Text.ToUpper();
            string aux4 = cmbDoenca.Text.ToUpper();            

            if (aux != "GATO" && aux != "CACHORRO") {
                MessageBox.Show("Animal indisponível para inserção", "Erro");
            }

            if (aux2 != "PEQUENO" && aux2 != "MÉDIO" && aux2 != "MEDIO" && aux2 != "GRANDE") {
                MessageBox.Show("Porte indisponível para inserção", "Erro");
            }

            if (aux3 != "S" && aux3 != "N") {
                MessageBox.Show("Opção indisponível para inserção", "Erro");
            }

            if (aux4 != "S" && aux4 != "N") {
                MessageBox.Show("Opção indisponível para inserção", "Erro");
            }

            try {
                idade = int.Parse(txbIdade.Text);                
            }
            catch (Exception){                
                MessageBox.Show("Idade incorreta inserida", "Erro");                
            }            

            try {
                peso = double.Parse(txbPeso.Text);                
            }
            catch(Exception) {                
                MessageBox.Show("Peso incorreto inserido", "Erro");                
            }            

            if (idade < 0) {
                MessageBox.Show("Idade incorreta inserida", "Erro");
            }

            if (peso < 0) {
                MessageBox.Show("Peso incorreto inserido", "Erro");
            }

            
            _4th_Screen p = new _4th_Screen();
            p.ShowDialog();
            





        }

        private void BtnLimpar_Click(object sender, EventArgs e) {
            cmbAnimal.Text = null;
            txbNome.Text = null;
            txbPeso.Text = null;
            txbIdade.Text = null;
            txbRaca.Text = null;
            cmbPorte.Text = null;
            cmbDef.Text = null;
            cmbDoenca.Text = null;
            txbVac.Text = null;
        }

        private void Label12_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
