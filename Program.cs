using Microsoft.Data.Sqlite;
namespace end2endCompare;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando");
        E2E_Repository.CheckTable();
        E2E_Controller.getUserInput();
    }
}


