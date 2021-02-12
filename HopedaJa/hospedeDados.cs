using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class hospedeDados
    {
        public void inserir(hospede c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO hospede" +
                "(idhospede, nome,cpf,endereco,cidade,estado,telefone)" +
                "values (@idhospede,@nome,@cpf,@endereco,@cidade,@estado,@telefone)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@idhospede", SqlDbType.Int).Value = c.idhospede;
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@cpf", SqlDbType.VarChar).Value = c.cpf;
            qr.Parameters.Add("@endereco", SqlDbType.VarChar).Value = c.endereco;
            qr.Parameters.Add("@cidade", SqlDbType.VarChar).Value = c.cidade;
            qr.Parameters.Add("@estado", SqlDbType.VarChar).Value = c.estado;
            qr.Parameters.Add("@telefone", SqlDbType.VarChar).Value = c.telefone;
            qr.ExecuteNonQuery();
            Conexao.fechar();
        }
        public void apagarHospede(int idhospede)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "delete from hospede where idhospede= @id");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@id", SqlDbType.Int).Value = idhospede;
            qr.ExecuteNonQuery();
            con.fechar();
        }

        public void AlterarHospede(hospede c)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
                "update hospede set nome=@nome ," +
                " cpf=@cpf , " +
                " endereco=@endereco ," +
                " cidade=@cidade , " +
                " estado=@estado , " +
                " telefone=@telefone " +
                "where idhospede=@idhospede");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@cpf", SqlDbType.VarChar).Value = c.cpf;
            qr.Parameters.Add("@endereco", SqlDbType.VarChar).Value = c.endereco;
            qr.Parameters.Add("@cidade", SqlDbType.VarChar).Value = c.cidade;
            qr.Parameters.Add("@estado", SqlDbType.VarChar).Value = c.estado;
            qr.Parameters.Add("@telefone", SqlDbType.VarChar).Value = c.telefone;
            qr.Parameters.Add("@idhospede", SqlDbType.Int).Value = c.idhospede;      
            qr.ExecuteNonQuery();
            con.fechar();


        }

        public List<hospede> listaHospede()
        {
            conexao Conexao = new conexao();
            String sql = "Select idhospede, nome, cpf, endereco, cidade, estado, telefone from hospede";
            SqlCommand qr = new SqlCommand(sql);
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
        }
        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(idhospede),0) from hospede",
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

        public List<hospede> listaHospede(String nome)
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
        }
    }
}
