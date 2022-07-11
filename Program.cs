// See https://aka.ms/new-console-template for more information

using CSharp_Biblioteca.Persona;
using CSharp_Biblioteca.Library;
using System.Data.SqlClient;

// Creo 2 utenti 
User marco = new User("email@email.com", "passssss", 354254515, "Marco", "dotNet");
User mimmo = new User("mimmo@email.com", "sdsdsfsaf", 456584545, "Mimmo", "Barbieri");
// Creo lista utenti registrati
List<User> userList = new List<User>();
userList.Add(marco);
userList.Add(mimmo);

//CREO Una lista di classi DOCUMENT nella quale aggiungero i documenti di type libro e dvd 
List<Document> allDocs = new List<Document>();

allDocs.Add(new Book("il Signore degli anelli", "Fantasy"));
allDocs.Add(new Book("Super Thinking", "Psicologia"));



foreach (Document doc in allDocs) {
    Console.WriteLine("Titolo: {0} \n Categoria: {1}", doc.Title, doc.Category);
    Console.WriteLine(doc.GetType().Name); // Nome dell type del documento. 
    Console.WriteLine("///////////////////////////////////");
}


// CREO L'ACCESSO AL DB
string strDiConnessioneDB = "Data Source=localhost;Initial Catalog=libreria;Integrated Security=True";
using (SqlConnection connessioneDB = new SqlConnection(strDiConnessioneDB) )
{
    try
    {
        connessioneDB.Open();
        string query = "SELECT * FROM Users;";
        using (SqlCommand cmd = new SqlCommand(query, connessioneDB))
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read()) {
                Console.WriteLine(reader.GetValue(1));
                Console.WriteLine(reader.GetValue(2));
            }
        }


    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.ToString());
    }
}








//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...


// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro
