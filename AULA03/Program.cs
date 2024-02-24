
// var conexao =  new SqliteConnection("Data Souce=db/dados.db");

// conexao.Open();

// conexao.Close();


//outro método de fazer a conexão
using Microsoft.Data.Sqlite;
// conexao.Close(); "using" o torna desnecessario. 
using(var conexao = new SqliteConnection("Data Source=db/dados.db")){

    // conexao.Open();
    // var cmd = conexao.CreateCommand();
    // // cmd.CommandText = "INSERT INTO contato(id,nome,email)" +
    // //                    "VALUES(@id, @nome, @email)";

    // // cmd.CommandText = "UPDATE contato" + 
    // //                 "SET nome=@nome, email=@email WHERE id=@id";
    // // cmd.Parameters.AddWithValue("@id",4);
    // // cmd.Parameters.AddWithValue("@nome", "Daniel");
    // // cmd.Parameters.AddWithValue("@email","daniel@email.com");

    // cmd.CommandText = "DELETE FROM contato WHERE id=@id";
    // cmd.Parameters.AddWithValue("@id", 4);

    // cmd.ExecuteNonQuery();

    conexao.Open();

    var cmd = conexao.CreateCommand();
    cmd.CommandText = "SELECT * FROM contato";

    var dr = cmd.ExecuteReader();

    while(dr.Read()){
        Console.WriteLine($"{dr["nome"]}:{dr["email"]}")/
    }

    dr.Close();

}
