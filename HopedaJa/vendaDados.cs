using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class vendaDados
    {
        public void inserir(venda c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO venda" +
                "(codvenda, prod, qtde, total)" +
                "values (@codvenda,@prod,@qtde,@total)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@codvenda", SqlDbType.Int).Value = c.codvenda;
            qr.Parameters.Add("@prod", SqlDbType.VarChar).Value = c.prod;
            qr.Parameters.Add("@qtde", SqlDbType.VarChar).Value = c.qtde;
            qr.Parameters.Add("@total", SqlDbType.VarChar).Value = c.total;
            qr.ExecuteNonQuery();
            Conexao.fechar();
        }

        public List<venda> listaVenda()
        {
            conexao Conexao = new conexao();
            String sql = "Select codvenda, prod, qtde, total from venda";
            SqlCommand qr = new SqlCommand(sql);
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<venda> vendas = new List<venda>();
                    while (dr.Read())
                    {
                        venda p = new venda();
                        p.codvenda = dr.GetInt32(0);
                        p.prod = dr.GetString(1);
                        p.qtde = dr.GetInt32(2);
                        p.total = dr.GetString(3);

                        vendas.Add(p);
                    }
                    Conexao.fechar();
                    return vendas;
                }
            }
            Conexao.fechar();
            return null;
        }

        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(codvenda),0) from venda",
              con.abrir());
            SqlDataReader dr = qr.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                int valor = dr.GetInt32(0);
                con.fechar();
                return ++valor;
            }
            con.fechar();
            return 0;
        }
    }
}
