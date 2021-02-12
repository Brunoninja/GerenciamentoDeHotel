using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class reservaDados
    {
        public void inserir(reservas c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO reserva" +
                "(codreserva,idhospede,idapartamento,entrada,saida,categoria,diarias,adultos,criancas,situacao,valortotal)" +
                "values (@codreserva,@idhospede,@idapartamento,@entrada,@saida,@categoria,@diarias,@adultos,@criancas,@situacao,@valortotal)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@codreserva", SqlDbType.Int).Value = c.idreserva;
            qr.Parameters.Add("@idhospede", SqlDbType.Int).Value = c.idhospede;
            qr.Parameters.Add("@idapartamento", SqlDbType.Int).Value = c.idapartamento;
            qr.Parameters.Add("@entrada", SqlDbType.VarChar).Value = c.entrada;
            qr.Parameters.Add("@saida", SqlDbType.VarChar).Value = c.saida;
            qr.Parameters.Add("@categoria", SqlDbType.VarChar).Value = c.categoria;
            qr.Parameters.Add("@diarias", SqlDbType.Int).Value = c.diarias;
            qr.Parameters.Add("@adultos", SqlDbType.Int).Value = c.adultos;
            qr.Parameters.Add("@criancas", SqlDbType.Int).Value = c.criancas;
            qr.Parameters.Add("@situacao", SqlDbType.VarChar).Value = c.situacao;
            qr.Parameters.Add("@valortotal", SqlDbType.VarChar).Value = c.valortotal;

            qr.ExecuteNonQuery();
            Conexao.fechar();
        }
        public void apagarReserva(int idreserva)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "delete from reserva where codreserva= @codreserva");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@codreserva", SqlDbType.Int).Value = idreserva;
            qr.ExecuteNonQuery();
            con.fechar();
        }

        public void AlterarReserva(reservas c)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
                "update reserva set entrada=@entrada ," +
                " saida=@saida , " +
                " categoria=@categoria ," +
                " diarias=@diarias , " +
                " adultos=@adultos , " +
                " criancas=@criancas , " +
                " situacao=@situacao , " +
                " valortotal=@valortotal " +
                " where codreserva=@codreserva");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@entrada", SqlDbType.VarChar).Value = c.entrada;
            qr.Parameters.Add("@saida", SqlDbType.VarChar).Value = c.saida;
            qr.Parameters.Add("@categoria", SqlDbType.VarChar).Value = c.categoria;
            qr.Parameters.Add("@diarias", SqlDbType.Int).Value = c.diarias;
            qr.Parameters.Add("@adultos", SqlDbType.Int).Value = c.adultos;
            qr.Parameters.Add("@criancas", SqlDbType.Int).Value = c.criancas;
            qr.Parameters.Add("@situacao", SqlDbType.VarChar).Value = c.situacao;
            qr.Parameters.Add("@valortotal", SqlDbType.VarChar).Value = c.valortotal;
            qr.Parameters.Add("@codreserva", SqlDbType.Int).Value = c.idhospede;
            qr.ExecuteNonQuery();
            con.fechar();


        }


        public List<reservas> listaReserva()
        {
            conexao Conexao = new conexao();
            String sql = "Select codreserva, idhospede, idapartamento, entrada, saida, categoria, diarias, valortotal from reserva";
            SqlCommand qr = new SqlCommand(sql);
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<reservas> reserva = new List<reservas>();
                    while (dr.Read())
                    {
                        reservas c = new reservas();
                        c.idreserva = dr.GetInt32(0);
                        c.idhospede = dr.GetInt32(1);
                        c.idapartamento = dr.GetInt32(2);              
                        c.entrada = dr.GetString(3);
                        c.saida = dr.GetString(4);
                        c.categoria = dr.GetString(5);
                        c.diarias = dr.GetInt32(6);                 
                        c.valortotal = dr.GetString(7);
                        reserva.Add(c);
                    }
                    Conexao.fechar();
                    return reserva;
                }
            }
            Conexao.fechar();
            return null;
        }
        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(codreserva),0) from reserva",
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

        public List<reservas> listaReserva(int codreserva)
        {
            conexao Conexao = new conexao();
            String sql = "Select codreserva, idhospede, idapartamento, entrada, saida, categoria, diarias, adultos, criancas, situacao, valortotal from reserva" +
            "where codreserva LIKE @codreserva";
            SqlCommand qr = new SqlCommand(sql);
            qr.Parameters.Add("@codreserva", SqlDbType.Int).Value =
                "%" + codreserva + "%";
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<reservas> reserva = new List<reservas>();
                    while (dr.Read())
                    {
                        reservas c = new reservas();
                        c.idreserva = dr.GetInt32(0);
                        c.idhospede = dr.GetInt32(1);
                        c.idapartamento = dr.GetInt32(2);
                        c.entrada = dr.GetString(3);
                        c.saida = dr.GetString(4);
                        c.categoria = dr.GetString(5);
                        c.diarias = dr.GetInt32(6);
                        c.adultos = dr.GetInt32(7);
                        c.criancas = dr.GetInt32(8);
                        c.situacao = dr.GetString(9);
                        c.valortotal = dr.GetString(10);
                        reserva.Add(c);
                    }
                    Conexao.fechar();
                    return reserva;
                }
            }
            Conexao.fechar();
            return null;
        }

    }
}
