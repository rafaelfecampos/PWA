using System.Runtime.InteropServices;
using Microsoft.Data.Sqlite;
using objeto;

Obj obj = new Obj();

Console.WriteLine("Informe as informações do cliente a ser adicionado no banco de dados: ");
Console.Write("-Id: ");
obj.Id = Console.ReadLine();
Console.Write("-Nome: ");
obj.Nome = Console.ReadLine();
Console.Write("-Email: ");
obj.Email = Console.ReadLine();
Console.Write("-Telefone: ");
obj.Telefone = Console.ReadLine();


using(var connection = new SqliteConnection("Data Source = database/db.db")){
    connection.Open();

    var command = connection.CreateCommand();

    command.CommandText = "INSERT INTO cliente(id, nome, email, telefone)"+
                    " VALUES (@Id, @Nome, @Email, @Telefone)";
    
    command.Parameters.AddWithValue("@Id", obj.Id);
    command.Parameters.AddWithValue("@Nome", obj.Nome);
    command.Parameters.AddWithValue("@Email", obj.Email);
    command.Parameters.AddWithValue("@Telefone", obj.Telefone);

    command.ExecuteNonQuery();


    connection.Close();
}