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
    public partial class Form1 : Form
    {
        Form3 Pedido;
        DAO dao;

        public Form1()
        {
            InitializeComponent();
            Pedido = new Form3();
            dao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cpf = textBox2.Text;
            Visible = false;
            dao.Inserir(nome, cpf);
            Pedido.ShowDialog();//Mostrar a tela ao ser chamada.
            Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
