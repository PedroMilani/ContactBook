using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ContatoRepository
    {
        private string ConnectionString = "Server=AgendaDB.mssql.somee.com;Database=AgendaDB;User Id=bdosilva_SQLLogin_1;Password=hw4prqorp6;TrustServerCertificate=True";
        //private string ConnectionString = @"Server=(localdb)\MSSqlLocalDb;Database=AgendaDB;TrustServerCertificate=True";
        
        public List<ContatoDTO> ObterTodosContatos()
        {
            List<ContatoDTO> Contatos = new List<ContatoDTO>();

            try
            {
                //Abre a conexão com o banco
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Contatos", con);

                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    //Se tiver registros pra trazer, vai adicionando na lista de Contatos um novo objeto Contato
                    while (reader.Read())
                    {
                        Contatos.Add(new ContatoDTO()
                        {
                            Id = reader["id"].ToString().Trim(),
                            Nome = reader["Nome"].ToString().Trim(),
                            Endereco = reader["Endereco"].ToString().Trim(),
                            Telefone = reader["Telefone"].ToString().Trim(),
                            Email = reader["Email"].ToString().Trim(),
                            CPF = reader["CPF"].ToString().Trim()
                        });
                    }

                    reader.Close();
                    con.Close();

                    return Contatos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ContatoDTO PesquisarContato(string Nome)
        {
            ContatoDTO Contatos = new ContatoDTO();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    //string query = $"SELECT * FROM Contatos  WHERE Nome = '{Nome}'";

                    SqlCommand command = new SqlCommand("SELECT * FROM Contatos  WHERE Nome = @nome", sqlConnection);
                    command.Parameters.AddWithValue("@nome", Nome);

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return new ContatoDTO()
                        {
                            Id = reader["id"].ToString().Trim(),
                            Nome = reader["Nome"].ToString().Trim(),
                            Endereco = reader["Endereco"].ToString().Trim(),
                            Telefone = reader["Telefone"].ToString().Trim(),
                            Email = reader["Email"].ToString().Trim(),
                            CPF = reader["CPF"].ToString().Trim()
                        };
                    }

                    reader.Close();
                    sqlConnection.Close();

                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ContatoDTO PesquisarContatoEnd(string Endereco)
        {
            ContatoDTO Contatos = new ContatoDTO();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM Contatos  WHERE Endereco = @Endereco", sqlConnection);
                    command.Parameters.AddWithValue("@Endereco", Endereco);

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return new ContatoDTO()
                        {
                            Id = reader["id"].ToString().Trim(),
                            Nome = reader["Nome"].ToString().Trim(),
                            Endereco = reader["Endereco"].ToString().Trim(),
                            Telefone = reader["Telefone"].ToString().Trim(),
                            Email = reader["Email"].ToString().Trim(),
                            CPF = reader["CPF"].ToString().Trim()
                        };
                    }

                    reader.Close();
                    sqlConnection.Close();

                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ContatoDTO PesquisarContatoId(string id)
        {
            ContatoDTO Contatos = new ContatoDTO();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM Contatos  WHERE id = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return new ContatoDTO()
                        {
                            Id = reader["id"].ToString().Trim(),
                            Nome = reader["Nome"].ToString().Trim(),
                            Endereco = reader["Endereco"].ToString().Trim(),
                            Telefone = reader["Telefone"].ToString().Trim(),
                            Email = reader["Email"].ToString().Trim(),
                            CPF = reader["CPF"].ToString().Trim()
                        };
                    }

                    reader.Close();
                    sqlConnection.Close();

                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public string AdicionarContato(ContatoDTO contatoDTO)
        {
            string msg = string.Empty;
            if (!string.IsNullOrEmpty(contatoDTO.Nome) && !string.IsNullOrEmpty(contatoDTO.Endereco) && !string.IsNullOrEmpty(contatoDTO.Telefone) && !string.IsNullOrEmpty(contatoDTO.Email) && !string.IsNullOrEmpty(contatoDTO.CPF))
            {

                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                try
                {
                    using (sqlConnection)
                    {
                        string insertString = "INSERT INTO Contatos(Nome,Endereco,Telefone,Email,CPF) VALUES(@Nome,@Endereco,@Tel,@Email,@CPF)";
                        SqlCommand command = new SqlCommand(insertString, sqlConnection);

                        command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = contatoDTO.Nome; //SqlDbType.NVarChar).Value = textbox2.text;
                        command.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = contatoDTO.Endereco;
                        command.Parameters.Add("@Tel", SqlDbType.VarChar).Value = contatoDTO.Telefone;
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = contatoDTO.Email;
                        command.Parameters.Add("@CPF", SqlDbType.VarChar).Value = contatoDTO.CPF;
                        command.ExecuteNonQuery();
                        return msg = "Contato adicionado com sucesso!";
                    }
                }
                catch (Exception)
                {
                    //throw;
                    return msg = "Erro ao adicionar o contato, talvez o CPF não tenha sido informado corretamente (11 números).";
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                return msg = "Preencha os campos";
            }
        }
        public string DeletarContato(int id)
        {
            string msg = string.Empty;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    SqlCommand commandReader = new SqlCommand("SELECT CPF FROM Contatos WHERE id=@id", sqlConnection);

                    sqlConnection.Open();
                    string IdCheck = string.Empty;
                    commandReader.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = commandReader.ExecuteReader();
                    while (reader.Read())
                    {
                        {
                            IdCheck = reader["CPF"].ToString().Trim();
                        };
                    }

                    reader.Close();
                    if (string.IsNullOrEmpty(IdCheck))
                    {
                        sqlConnection.Close();
                        return msg = "Id não encontrado.";
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("DELETE FROM Contatos WHERE id=@id", sqlConnection);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        sqlConnection.Close();

                        return msg = "Contato apagado.";
                    }
                }
            }
            catch (Exception)
            {
                return msg = "Algo deu errado ao deletar contato.";
            }
        }
        public string UpdateContato(ContatoDTO contatoDTO, int id)
        {
            string msg = string.Empty;
            if (string.IsNullOrEmpty(contatoDTO.Nome) && string.IsNullOrEmpty(contatoDTO.Endereco) && string.IsNullOrEmpty(contatoDTO.Telefone) && string.IsNullOrEmpty(contatoDTO.Email) && string.IsNullOrEmpty(contatoDTO.CPF))
            {
                return msg = "Insira algum dado para atualizar.";
            }
            else
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        SqlCommand commandReader = new SqlCommand("SELECT CPF FROM Contatos WHERE id=@id", sqlConnection);

                        sqlConnection.Open();
                        string IdCheck = string.Empty;
                        commandReader.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = commandReader.ExecuteReader();
                        while (reader.Read())
                        {
                            {
                                IdCheck = reader["CPF"].ToString().Trim();
                            };
                        }

                        reader.Close();
                        if (string.IsNullOrEmpty(IdCheck))
                        {
                            sqlConnection.Close();
                            return msg = "Id não encontrado.";
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(contatoDTO.Nome))
                            {
                                SqlCommand command = new SqlCommand("UPDATE Contatos SET Nome=@Nome WHERE id=@id", sqlConnection);
                                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = contatoDTO.Nome;
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                            if (!string.IsNullOrEmpty(contatoDTO.Endereco))
                            {
                                SqlCommand command = new SqlCommand("UPDATE Contatos SET Endereco=@Endereco WHERE id=@id", sqlConnection);
                                command.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = contatoDTO.Endereco;
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                            if (!string.IsNullOrEmpty(contatoDTO.Telefone))
                            {
                                SqlCommand command = new SqlCommand("UPDATE Contatos SET Telefone=@Telefone WHERE id=@id", sqlConnection);
                                command.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = contatoDTO.Telefone;
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                            if (!string.IsNullOrEmpty(contatoDTO.Email))
                            {
                                SqlCommand command = new SqlCommand("UPDATE Contatos SET Email=@Email WHERE id=@id", sqlConnection);
                                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = contatoDTO.Email;
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                            if (!string.IsNullOrEmpty(contatoDTO.CPF))
                            {
                                SqlCommand command = new SqlCommand("UPDATE Contatos SET CPF=@CPF WHERE id=@id", sqlConnection);
                                command.Parameters.Add("@CPF", SqlDbType.VarChar).Value = contatoDTO.CPF;
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }

                            sqlConnection.Close();
                            return msg = "Contato atualizado.";

                        }


                    }
                }
                catch (Exception)
                {
                    return msg = "Algo deu errado ao atualizar contato, talvez o formato do CPF esteja errado.";

                }

            }
        }
    }
}
