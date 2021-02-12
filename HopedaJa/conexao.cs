using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class conexao
    {
        String dados = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbrun\Documents\HopedaJa\HopedaJa\Dados.mdf;Integrated Security=True";
        SqlConnection conn;
        public conexao()
        {
            conn = new SqlConnection(dados);
        }

        public SqlConnection abrir()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void fechar()
        {
            conn.Close();
        }
    }
}
