using System.Data.SqlClient;


namespace ProjetoClientes;
class Program
{
    static void Main(string[] args)
    {
        try{
            //Instanciando o builder
            SqlConnectionStringBuilder builder  = new SqlConnectionStringBuilder(
                "User Id = sa; Password=12345;"+
                "Server=localhost\\SQLEXPRESS;" +
                "Database=projetoclientes;" +
                "Trusted_Connection=False;"
            );
            // Preparando a forma de conectar e conectando ao banco de dados
            using(SqlConnection conexao =  new SqlConnection(builder.ConnectionString)){
                string sql = "Select * from clientes";

                using(SqlCommand  comando = new SqlCommand(sql, conexao)){
                    conexao.Open();
                    using(SqlDataReader leitor = comando.ExecuteReader()){
                        while (leitor.Read()){
                            System.Console.WriteLine("id: {0}", leitor.GetSqlInt32(0));
                            System.Console.WriteLine("nome: {0}", leitor.GetSqlInt32(1));
                            System.Console.WriteLine("email: {0}", leitor.GetSqlInt32(2));
                            
                        }
                    }
                }
            }
        }
        catch(Exception e){
            System.Console.WriteLine("Erro: "+e.ToString());
        }
    }
}
