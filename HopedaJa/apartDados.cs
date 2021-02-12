using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class apartDados
    {
        public void inserir(apartamentos c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO apartamentos" +
                "(id,leitos,situacao,categoria,descricao)" +
                "values (@id,@leitos,@situacao,@categoria,@descricao)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@id", SqlDbType.Int).Value = c.id;
            qr.Parameters.Add("@leitos", SqlDbType.Int).Value = c.leitos;
            qr.Parameters.Add("@situacao", SqlDbType.VarChar).Value = c.situacao;
            qr.Parameters.Add("@categoria", SqlDbType.VarChar).Value = c.categoria;
            qr.Parameters.Add("@descricao", SqlDbType.VarChar).Value = c.descricao;
            qr.ExecuteNonQuery();
            Conexao.fechar();
        }
        public void apagarApart(int id)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "delete from apartamentos where id= @id");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@id", SqlDbType.Int).Value = id;
            qr.ExecuteNonQuery();
            con.fechar();
        }

        public void AlterarApart(apartamentos c)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
                "update apartamentos set leitos=@leitos ," +
                " situacao=@situacao , " +
                " categoria=@categoria ," +
                " descricao=@descricao " +
                "where id=@id");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@leitos", SqlDbType.Int).Value = c.leitos;
            qr.Parameters.Add("@situacao", SqlDbType.VarChar).Value = c.situacao;
            qr.Parameters.Add("@categoria", SqlDbType.VarChar).Value = c.categoria;
            qr.Parameters.Add("@descricao", SqlDbType.VarChar).Value = c.descricao;
            qr.Parameters.Add("@id", SqlDbType.Int).Value = c.id;
            qr.ExecuteNonQuery();
            con.fechar();


        }

        public List<apartamentos> listaApart()
        {
            conexao Conexao = new conexao();
            String sql = "Select id, leitos, situacao, categoria, descricao from apartamentos";
            SqlCommand qr = new SqlCommand(sql);
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<apartamentos> apart = new List<apartamentos>();
                    while (dr.Read())
                    {
                        apartamentos c = new apartamentos();
                        c.id = dr.GetInt32(0);
                        c.leitos = dr.GetInt32(1);
                        c.situacao = dr.GetString(2);
                        c.categoria = dr.GetString(3);
                        c.descricao = dr.GetString(4);
                        apart.Add(c);
                    }
                    Conexao.fechar();
                    return apart;
                }
            }
            Conexao.fechar();
            return null;
        }
        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(id),0) from apartamentos",
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

       /* public List<hospede> listaHospede(String nome)
        {
            conexao Conexao = new conexao();
            String sql = "Select idhospede, nome, cpf, endereco, cidade," +
                "estado, telefone from hospede " +
            "where nome LIKE @nome";
            SqlCommand qr = new SqlCommand(sql);
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value =
                "%" + nome + "%";
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<hospede> hospedes = new List<hospede>();
                    while (dr.Read())
                    {
                        hospede c = new hospede();
                        c.idhospede = dr.GetInt32(0);
                        c.nome = dr.GetString(1);
                        c.cpf = dr.GetString(2);
                        c.endereco = dr.GetString(3);
                        c.cidade = dr.GetString(4);
                        c.estado = dr.GetString(5);
                        c.telefone = dr.GetString(6);
                        hospedes.Add(c);
                    }
                    Conexao.fechar();
                    return hospedes;
                }
            }
            Conexao.fechar();
            return null;
        }*/
    }
}
