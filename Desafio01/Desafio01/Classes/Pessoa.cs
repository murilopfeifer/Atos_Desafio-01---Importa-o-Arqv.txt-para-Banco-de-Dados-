using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio01
{
    class Pessoa
    {
        public StreamReader sr;

        public int id_pessoa { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        
        //public int adicionarPessoa()
        public bool adicionarPessoa()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            //command.CommandText = "insert into pessoa1 " + " values (@nome_pessoa, @telefone_pessoa, @cidade_pessoa, @rg_pessoa, @cpf_pessoa,@id_pessoa);" + "SELECT CAST(scope_identity() AS int)"; 
            command.CommandText = "insert into pessoa1 " + " values (@nome_pessoa, @telefone_pessoa, @cidade_pessoa, @rg_pessoa, @cpf_pessoa);";
            command.Parameters.Add("@nome_pessoa", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@telefone_pessoa", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cidade_pessoa", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@rg_pessoa", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cpf_pessoa", System.Data.SqlDbType.VarChar);
            //command.Parameters.Add("@id_pessoa", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = telefone;
            command.Parameters[2].Value = cidade;
            command.Parameters[3].Value = rg;
            command.Parameters[4].Value = cpf;
            //command.Parameters[5].Value = id_pessoa;



            try
            {
                /*int retorno = (int)command.ExecuteScalar();
                return retorno;*/

                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }

            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }

        }
        public class Aluno : Pessoa
        {
                        
            public string matricula { get; set; }
            public string codcurso { get; set; }
            public string nomecurso { get; set; }
            public string nome_pessoa { get; set; }
            public int fk_pessoa { get; set; }




            public bool adicionarCurso()
            {
                Banco banco = new Banco();

                SqlConnection cn = banco.abrirConexao();
                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();

                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = System.Data.CommandType.Text;

                //int fk_pessoa = consultaid(nome_pessoa); 
              

                command.CommandText = "insert into curso1" + " values (@matricula, @cod_curso, @nome_curso, @nome_aluno);"; 
                command.Parameters.Add("@matricula", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@cod_curso", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@nome_curso", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@nome_aluno", System.Data.SqlDbType.VarChar);
                command.Parameters[0].Value = matricula;
                command.Parameters[1].Value = codcurso;
                command.Parameters[2].Value = nomecurso;
                command.Parameters[3].Value = nome_pessoa;

                try
                {
                    /*int retorno = (int)command.ExecuteScalar();
                    return retorno;*/
                    
                    command.ExecuteNonQuery();
                    tran.Commit();
                    return true;
                }

                catch (Exception ex)
                {
                    tran.Rollback();
                    return false;
                }
                finally
                {
                    banco.fecharConexao();
                }

            }

            public int consultaid(string nome_pessoa)
            {
                Banco banco = new Banco();
                try
                {
                    SqlConnection cn = banco.abrirConexao();
                    SqlTransaction tran = cn.BeginTransaction();
                    SqlCommand command = new SqlCommand("select id_pessoa from pessoa1 where nome_pessoa like " + nome_pessoa, cn);
                    MessageBox.Show(command.CommandText);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }

                    return 0;
                }
                catch (Exception ex)
                {
                    return 0;
                }
                finally
                {
                    banco.fecharConexao();
                }
            }
        }
    }
}
