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
        //Form1 for1;

        class produto
        {
            public string nome;
            public double preco;

            public static implicit operator produto(List<produto> v)
            {
                throw new NotImplementedException();
            }
        }

        List<produto> LISTA_PRODUTOS;
        List<produto> LISTA_COMPRAS;

        public Form2()
        {
           // for1 = new Form1();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LISTA_PRODUTOS = new List<produto>()
            {
                new produto(){ nome = "Pastel de Carne", preco = 8 },
                new produto(){ nome = "Pastel de Frango", preco = 7 },
                new produto(){ nome = "Pastel de Carne Seca", preco = 10 },
                new produto(){ nome = "Pastel de Pizza", preco = 8 },
                new produto(){ nome = "Pastel de Calabresa", preco = 9 },
                new produto(){ nome = "Coca-Cola", preco = 10 },
                new produto(){ nome = "Pepsi", preco = 6 },
                new produto(){ nome = "Guarana Antártica", preco = 6 },
                new produto(){ nome = "Heineken", preco = 12 },
            };

            foreach (produto p in LISTA_PRODUTOS)
            {
                lst_produtos.Items.Add(ConstruirLinhaProduto(p));
            }

            //Iniciar Compra
            IniciarCompras();
        }

        private static string ConstruirLinhaProduto(produto p)
        {
            string preco = p.preco.ToString("0.00") + " R$";
            return p.nome + new string(' ', 30 - p.nome.Length - preco.Length) + preco;
        }

        private void IniciarCompras()
        {
            //inicia uma nova conta
            LISTA_COMPRAS = new List<produto>();
            lst_compras.Items.Clear();
            label_total.Text = "0,00 R$";
        }

        private void lst_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_produtos_DoubleClick(object sender, EventArgs e)
        {
            if (lst_produtos.SelectedIndex == -1) return;
            produto p = LISTA_PRODUTOS[lst_produtos.SelectedIndex];
            AdicionarProdutoCompra(p);
        }

        private void AdicionarProdutoCompra(produto p)
        {
            //adicionar um produto á compra
            LISTA_COMPRAS.Add(p);
            lst_compras.Items.Add(ConstruirLinhaProduto(p));

            //calcular total
            var total = LISTA_COMPRAS.Sum(i => i.preco);
            label_total.Text = total.ToString("0.00") + " R$";
        }

        private void button_finalizar_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Estamos fazendo o seu pedido. " +
                "Aguarde e pague no caixa após receber os produtos " +
                "Fábrica do Pastel agradece !" +
                "" + Environment.NewLine + label_total.Text);
            IniciarCompras();
        }

        private void lst_produtos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
