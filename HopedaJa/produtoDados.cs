using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class produtoDados
    {
        public void inserir(produto c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO produto" +
                "(idproduto, nome, preco, qtde)" +
                "values (@idproduto,@nome,@preco,@qtde)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@idproduto", SqlDbType.Int).Value = c.idproduto;
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@preco", SqlDbType.VarChar).Value = c.preco;
            qr.Parameters.Add("@qtde", SqlDbType.Int).Value = c.qtde;
            qr.ExecuteNonQuery();
            Conexao.fechar();
        }

        public void apagarProduto(int idproduto)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "delete from produto where idproduto= @id");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@id", SqlDbType.Int).Value = idproduto;
            qr.ExecuteNonQuery();
            con.fechar();
        }

        public void AlterarProduto(produto c)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
                "update produto set nome=@nome ," +
                " preco=@preco, qtde=@qtde , " +
                "where idproduto=@idproduto");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@preco", SqlDbType.VarChar).Value = c.preco;
            qr.Parameters.Add("@qtde", SqlDbType.Int).Value = c.qtde;
            qr.Parameters.Add("@idproduto", SqlDbType.Int).Value = c.idproduto;

            qr.ExecuteNonQuery();
            con.fechar();
        }

        public List<produto> listaProduto()
        {
            conexao Conexao = new conexao();
            String sql = "Select idproduto, nome, preco, qtde from produto";
            SqlCommand qr = new SqlCommand(sql);
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<produto> produto = new List<produto>();
                    while (dr.Read())
                    {
                        produto p = new produto();
                        p.idproduto = dr.GetInt32(0);
                        p.nome = dr.GetString(1);
                        p.preco = dr.GetString(2);
                        p.qtde = dr.GetInt32(3);

                        produto.Add(p);
                    }
                    Conexao.fechar();
                    return produto;
                }
            }
            Conexao.fechar();
            return null;
        }

        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(idproduto),0) from produto",
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

        public List<produto> listaProduto(String nome)
        {
            conexao Conexao = new conexao();
            String sql = "Select idproduto, nome," +
                "preco, qtde from produto " +
                "where nome LIKE @nome";
            SqlCommand qr = new SqlCommand(sql);
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value =
                "%" + nome + "%";
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<produto> produtos = new List<produto>();
                    while (dr.Read())
                    {
                        produto p = new produto();
                        p.idproduto = dr.GetInt32(0);
                        p.nome = dr.GetString(1);
                        p.preco = dr.GetString(2);
                        p.qtde = dr.GetInt32(3);
                        // p.preco = dr.GetDouble(2);
                        produtos.Add(p);
                    }
                    Conexao.fechar();
                    return produtos;
                }
            }
            Conexao.fechar();
            return null;
        }
    }
}
