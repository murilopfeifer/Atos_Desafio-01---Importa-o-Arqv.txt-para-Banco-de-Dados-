using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Desafio01.Pessoa;

namespace Desafio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_readtxt_Click(object sender, EventArgs e)
        {
            string l;
            string [] d;
            int countZ = 0;
            int countX = 0;
            StreamReader sr = new StreamReader("C:\\Jabulani\\desafio1.txt");
            l = sr.ReadLine();
            

            string nome_pessoa = "";

            while (l !=null)
            {
                
                d = l.Split('-');

                if (d[0].Equals("X"))
                {
                    l = sr.ReadLine();
                    continue;
                }


                else if (d[0].Equals ("Z"))
                {
                    /*Console.WriteLine("Tipo: " + d[0]);
                    Console.WriteLine("Nome: " + d[1]);
                    Console.WriteLine("Telefone: " + d[2]);
                    Console.WriteLine("Cidade: " + d[3]);
                    Console.WriteLine("RG: " + d[4]);
                    Console.WriteLine("CPF: " + d[5]);*/

                    Pessoa p = new Pessoa();


                    p.nome = d[1];
                    p.telefone = d[2];
                    p.cidade = d[3];
                    p.rg = d[4];
                    p.cpf = d[5];
                    nome_pessoa = p.nome;

                    countZ++;

                    //id_pessoa = p.adicionarPessoa();
                    p.adicionarPessoa();

                }

                else if (d[0].Equals("Y"))
                {

                    /*
                    Console.WriteLine("Tipo: " + d[0]);
                    Console.WriteLine("Matricula: " + d[1]);
                    Console.WriteLine("Código do curso: " + d[2]);
                    Console.WriteLine("Nome do curso: " + d[3]);
                    */

                    Pessoa.Aluno c = new Pessoa.Aluno();
                    c.matricula = d[1];
                    c.codcurso = d[2];
                    c.nomecurso = d[3];
                    c.nome_pessoa = nome_pessoa;

                    countX++;

                    c.adicionarCurso();
                }

                l = sr.ReadLine();
                
            }
            
            try
            {
                Banco bd = new Banco();

                string sql = "select * from pessoa1";

                DataTable dt = new DataTable();
                dt = bd.consultaPessoaAluno(sql);
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel fazer consulta na tabela Pessoa1");

            }

            MessageBox.Show("Dados carregados com sucesso ! \n" +  "Foram carregados " + countZ + " Pessoas, sendo " + countX + " delas, Alunos. ");


        }

        private void btn_LookPeAl_Click(object sender, EventArgs e)
        {
            try
            {
                Banco bd = new Banco();

                string sql = "select * from pessoa1";

                DataTable dt = new DataTable();
                dt = bd.consultaPessoaAluno(sql);
                dataGridView1.DataSource = dt;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel fazer consulta na tabela Pessoa1");
                
            }
          
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "delete from curso1";

            DataTable dt = new DataTable();
            dt = bd.consultaPessoaAluno(sql);
            dataGridView1.DataSource = dt;
            deletepessoa();

            MessageBox.Show("A tabela foi resetada !");
        }

        private void deletepessoa()
        {
            Banco bd = new Banco();

            string sql = "delete from pessoa1";
            
            DataTable dt = new DataTable();
            dt = bd.consultaPessoaAluno(sql);
            dataGridView1.DataSource = dt;
        }

        private void btn_mostraalunos_Click(object sender, EventArgs e)
        {

            Banco bd = new Banco();

            //string sql = "select * from pessoa1 full outer join curso1 on pessoa1.id_pessoa= curso1.fk_pessoa ";
            string sql = "select * from curso1";
            //"select * from pessoa1 full outer join curso1 on pessoa1.id_pessoa= curso1.fk_pessoa ";
            DataTable dt = new DataTable();
            dt = bd.consultaPessoaAluno(sql);
            dataGridView1.DataSource = dt;

        }

        private void btn_todos_Click(object sender, EventArgs e)
        {

            Banco bd = new Banco();

            
            string sql = "select * from pessoa1 full outer join curso1 on pessoa1.nome_pessoa like curso1.nome_aluno ";
            
            DataTable dt = new DataTable();
            dt = bd.consultaPessoaAluno(sql);
            dataGridView1.DataSource = dt;

        }


    }
    
}

