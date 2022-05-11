using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//Imports para conexão do Banco de Dados
using MySql.Data.MySqlClient;//Imports para realizar comandos no Banco de Dados

namespace Pastelaria
{
    class DAO
    {
        //Var


        MySqlConnection conexao;
        public string dados;
        public string resultado;

        //Vetores

        public string[] nome;
        public int[] cpf;
        public int i;
        public int contador = 0;

        public DAO()
        {


            conexao = new MySqlConnection("server=localhost;DataBase=Pastelaria;Uid=root;Password=;Convert Zero DateTime=True;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu Errado!\n\n" + e);
                conexao.Close();
            }
        }

        public void Inserir(string nome, string cpf)
        {
            try
            {
                dados = "('" + cpf + "','" + nome + "')";
                resultado = "Insert into cliente(cpf, nome) values" + dados;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                Console.WriteLine(resultado + "Cadastro feito com Sucesso !");
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo Deu Errado!\n\n" + e);
            }
        }

        public void PreencherVetor(string nomeTabela)
        {
            string query = "select * from " + nomeTabela;


            MySqlCommand coletar = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();
            if (nomeTabela == "cliente")
            {
                cpf = new int[100];
                nome = new string[100];

                for (i = 0; i < 100; i++)
                {
                    cpf[i] = 0;
                    nome[i] = "";
                }

                i = 0;
                while (leitura.Read())
                {
                    cpf[i] = (int)Convert.ToInt64(leitura["cpf"]);
                    nome[i] = leitura["nome"] + "";
                }
                leitura.Close();
            }
        }
    }
}
