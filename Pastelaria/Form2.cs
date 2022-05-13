using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria
{   
    public partial class Form2 : Form
    {
        Form4 pix;
        public Form2()
        {
            pix = new Form4();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos fazendo o seu pedido. " +
                           Environment.NewLine + "Aguarde e pague no caixa após receber os produtos " +
                           Environment.NewLine + " " +    
                           Environment.NewLine + "Fábrica do Pastel agradece !");
            this.Close();
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            pix.ShowDialog();//Mostrar Tela Pagamento Pix
            
            
        }

      
    }
}
