using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    class funcDados
    {
        public void inserir(funcionario c)
        {
            conexao Conexao = new conexao();
            SqlCommand qr = new SqlCommand(
                "INSERT INTO funcionario" +
                "(idfunc,nome,cpf,datanasc,telefone,cargo,turno,admissao,senha)" +
                "values (@idfunc,@nome,@cpf,@datanasc,@telefone,@cargo,@turno,@admissao,@senha)");
            qr.Connection = Conexao.abrir();
            qr.Parameters.Add("@idfunc", SqlDbType.Int).Value = c.idfunc;
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@cpf", SqlDbType.VarChar).Value = c.cpf;
            qr.Parameters.Add("@datanasc", SqlDbType.VarChar).Value = c.datanasc;
            qr.Parameters.Add("@telefone", SqlDbType.VarChar).Value = c.telefone;
            qr.Parameters.Add("@cargo", SqlDbType.VarChar).Value = c.cargo;
            qr.Parameters.Add("@turno", SqlDbType.VarChar).Value = c.turno;
            qr.Parameters.Add("@admissao", SqlDbType.VarChar).Value = c.admissao;
            //qr.Parameters.Add("@imagem", SqlDbType.Image).Value = ConverterImagemParaByteArray(c);
            qr.Parameters.Add("@senha", SqlDbType.VarChar).Value = c.senha;
            qr.ExecuteNonQuery();
            Conexao.fechar();
        }

       /* private byte[] ConverterImagemParaByteArray(funcionario c)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                c.imagem.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }*/
        public void apagarFuncionario(int idfunc)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "delete from funcionario where idfunc= @id");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@id", SqlDbType.Int).Value = idfunc;
            qr.ExecuteNonQuery();
            con.fechar();
        }

        public void AlterarFuncionario(funcionario c)
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
                "update funcionario set nome=@nome ," +
                " cpf=@cpf , " +
                " datanasc=@datanasc ," +
                " telefone=@telefone , " +
                " cargo=@cargo , " +
                " turno=@turno ," +
                " admissao=@admissao ," +           
                " senha=@senha " +
                "where idfunc=@idfunc");
            qr.Connection = con.abrir();
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.nome;
            qr.Parameters.Add("@cpf", SqlDbType.VarChar).Value = c.cpf;
            qr.Parameters.Add("@datanasc", SqlDbType.VarChar).Value = c.datanasc;
            qr.Parameters.Add("@telefone", SqlDbType.VarChar).Value = c.telefone;
            qr.Parameters.Add("@cargo", SqlDbType.VarChar).Value = c.cargo;
            qr.Parameters.Add("@turno", SqlDbType.VarChar).Value = c.turno;
            qr.Parameters.Add("@admissao", SqlDbType.VarChar).Value = c.admissao;
            qr.Parameters.Add("@idfunc", SqlDbType.Int).Value = c.idfunc;
           /// qr.Parameters.Add("@imagem", SqlDbType.Image).Value = c.imagem;
            qr.Parameters.Add("@senha", SqlDbType.VarChar).Value = c.senha;
            qr.ExecuteNonQuery();
            con.fechar();


        }

        public List<funcionario> listaFuncionario()
        {
            conexao Conexao = new conexao();
            String sql = "Select idfunc, nome, cpf, datanasc, telefone, cargo, turno, admissao, imagem from funcionario";
            SqlCommand qr = new SqlCommand(sql);
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<funcionario> func = new List<funcionario>();
                    while (dr.Read())
                    {
                        funcionario c = new funcionario();
                        c.idfunc = dr.GetInt32(0);
                        c.nome = dr.GetString(1);
                        c.cpf = dr.GetString(2);
                        c.datanasc = dr.GetString(3);
                        c.telefone = dr.GetString(4);
                        c.cargo = dr.GetString(5);
                        c.turno = dr.GetString(6);
                        c.admissao = dr.GetString(7);
                        //c.imagem =   dr.GetString(8);
                       // c.imagem = (string)dr.GetSqlBinary(8);

                        func.Add(c);
                    }
                    Conexao.fechar();
                    return func;
                }
            }
            Conexao.fechar();
            return null;
        }
        public int proxCodigo()
        {
            conexao con = new conexao();
            SqlCommand qr = new SqlCommand(
              "select isnull(max(idfunc),0) from funcionario",
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

        public List<funcionario> listaFunc(String nome)
        {
            conexao Conexao = new conexao();
            String sql = "Select idfunc, nome, cpf, datanasc, telefone," +
                "cargo, turno, admissao, imagem from funcionario " +
            "where nome LIKE @nome";
            SqlCommand qr = new SqlCommand(sql);
            qr.Parameters.Add("@nome", SqlDbType.VarChar).Value =
                "%" + nome + "%";
            qr.Connection = Conexao.abrir();
            using (SqlDataReader dr = qr.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<funcionario> func = new List<funcionario>();
                    while (dr.Read())
                    {
                        funcionario c = new funcionario();
                        c.idfunc = dr.GetInt32(0);
                        c.nome = dr.GetString(1);
                        c.cpf = dr.GetString(2);
                        c.datanasc = dr.GetString(3);
                        c.telefone = dr.GetString(4);
                        c.cargo = dr.GetString(5);
                        c.turno = dr.GetString(6);
                        c.admissao = dr.GetString(7);
                        //c.imagem = dr.GetString(8);
                        func.Add(c);
                    }
                    Conexao.fechar();
                    return func;
                }
            }
            Conexao.fechar();
            return null;
        }
    }
}
