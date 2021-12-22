using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Banco
    {   
        private string stringConexao = "Data Source=localhost; Initial Catalog=desafio;User ID=usuario3; password=senha; language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try //tentar fazer algo 
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }


        public DataTable consultaPessoaAluno(string sql)
        {
            try
            {

                abrirConexao();

                
                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt); 

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }

        }




    }
}
