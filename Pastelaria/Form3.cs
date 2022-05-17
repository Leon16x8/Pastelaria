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
    public partial class Form3 : Form
    {
        DAO dao;
        Form2 Pagamento;

        

        class produto
        {             
            public string produtos;
            public double preco;

            public static implicit operator produto(List<produto> v)
            {
                throw new NotImplementedException();
            }
        }       

        List<produto> LISTA_PRODUTOS;
        List<produto> LISTA_COMPRAS;       

        
        public Form3()
        {
            dao = new DAO();
            Pagamento = new Form2();
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            //Adicionando Produtos
            LISTA_PRODUTOS = new List<produto>()
            {
                new produto(){ produtos = "Pastel de Carne", preco = 8 },
                new produto(){ produtos = "Pastel de Frango", preco = 7 },
                new produto(){ produtos = "Pastel de Carne Seca", preco = 10 },
                new produto(){ produtos = "Pastel de Pizza", preco = 8 },
                new produto(){ produtos = "Pastel de Calabresa", preco = 9 },
                new produto(){ produtos = "Coca-Cola", preco = 10 },
                new produto(){ produtos = "Pepsi", preco = 6 },
                new produto(){ produtos = "Guarana Antártica", preco = 6 },
                new produto(){ produtos = "Heineken", preco = 12 },
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
            return p.produtos + new string(' ', 30 - p.produtos.Length - preco.Length) + preco;
        }

        private void IniciarCompras()
        {
            //inicia uma nova conta
            LISTA_COMPRAS = new List<produto>();
            lst_compras.Items.Clear();
            label_total.Text = "0,00 R$";
        }

        private void lst_produtos_DoubleClick(object sender, EventArgs e)
        {
            //Selecionar Produto Clicando 2 Vezes
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
            string produtos = lst_compras.Text;
            string preco = label_total.Text;
            dao.InserirProdutos(produtos, preco);
            Visible = false;            
            Pagamento.ShowDialog();//Mostrar a tela ao ser chamada.
        }

        private void lst_compras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_total_Click(object sender, EventArgs e)
        {
            
        }

        public string ValorTotal()
        {
            return label_total.Text;
        }

        private void lst_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
