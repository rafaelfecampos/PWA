using Microsoft.Data.Sqlite;

// var conexao =  new SqliteConnection("Data Souce=db/dados.db");

// conexao.Open();

// conexao.Close();


//outro método de fazer a conexão
using Microsoft.Data.Sqlite;

using(var conexao =  new SqliteConnection("Data Souce=db/dados.db");)
{
conexao.Open();
}
