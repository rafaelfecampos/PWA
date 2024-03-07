// // var conexao =  new SqliteConnection("Data Souce=db/dados.db");

// // conexao.Open();

// // conexao.Close();


// //outro método de fazer a conexão
// using Microsoft.Data.Sqlite;
// // conexao.Close(); "using" o torna desnecessario. 
// using(var conexao = new SqliteConnection("Data Source=db/dados.db")){

//     // conexao.Open();
//     // var cmd = conexao.CreateCommand();
//     // // cmd.CommandText = "INSERT INTO contato(id,nome,email)" +
//     // //                    "VALUES(@id, @nome, @email)";

//     // // cmd.CommandText = "UPDATE contato" + 
//     // //                 "SET nome=@nome, email=@email WHERE id=@id";
//     // // cmd.Parameters.AddWithValue("@id",4);
//     // // cmd.Parameters.AddWithValue("@nome", "Daniel");
//     // // cmd.Parameters.AddWithValue("@email","daniel@email.com");

//     // cmd.CommandText = "DELETE FROM contato WHERE id=@id";
//     // cmd.Parameters.AddWithValue("@id", 4);

//     // cmd.ExecuteNonQuery();

//     conexao.Open();

//     var cmd = conexao.CreateCommand();
//     cmd.CommandText = "SELECT * FROM contato";

//     var dr = cmd.ExecuteReader();

//     while(dr.Read()){
//         Console.WriteLine($"{dr["nome"]}:{dr["email"]}")/
//     }

//     dr.Close();

// }

//------------------------------------------- Aula 27/02-------------------------------------------------------- 
using Dapper;
using Microsoft.Data.Sqlite;
using AULA03.models;
;

// var obj = new Contato{
//         Id = "5",
//         Nome = "Zé",
//         Email = "ze@email.com"
//     };

//     var tipo = obj.GetType();
//     Console.WriteLine(tipo.FullName);

//     foreach (var prop in tipo.GetProperties())
//     {
//         Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
//     }


using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
{
    conexao.Open();

    // var obj = new Contato{
    //     Id = "5",
    //     Nome = "Zé",
    //     Email = "ze@email.com"
    // };

    // const string sql = "DELETE FROM contato" + 
    //                     " WHERE id=@Id";
            
    // conexao.Execute(sql, obj);
    // conexao.Execute(sql, new {Id = "3"});//criar o novo obj para apagar o id = 3

    //imprimir uma busca
    /*const string sql = "SELECT * FROM contato "+
                        " WHERE nome LIKE @ParteNome"+
                        " ORDER BY nome";

    var objetos = conexao.Query<Contato>(sql, new{ ParteNome = "%"+"a"+"%"}); //cria uma lista de obejtos com os dados da tabela
    //"a" seria substituido por uma variável onde o usário digitaria o cactere ou a string
    foreach (var obj in objetos)
    {
        Console.WriteLine($"{obj.Nome} - {obj.Email}");
    }*/

    const string sql = "SELECT * FROM contato WHERE id = @Id";
    var obj = conexao.QuerySingle<Contato>(sql, new{ Id = 2});

    Console.WriteLine($"{obj.Nome} - {obj.Email}");
}