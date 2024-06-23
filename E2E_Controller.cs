using Microsoft.Data.Sqlite;
namespace end2endCompare;

class E2E_Controller
{
    public static void getUserInput(){
        Console.Clear();
        bool closeApp = false;
        while(closeApp == false){
            Console.WriteLine("\n================================================");
            Console.WriteLine("\nMENU DE OPÇÕES");
            Console.WriteLine("\n================================================");
            Console.WriteLine("\n(1) Inserir registros da TPX");
            Console.WriteLine("\n(2) Inserir registros da Autbank");
            Console.WriteLine("\n(3) Exibir todos registros");
            Console.WriteLine("\n(4) Processar relatório");
            Console.WriteLine("\n(5) Configurar Aplicação");
            Console.WriteLine("\n(0) Fechar Console");
            Console.WriteLine("\n================================================");

            string? commandInput = Console.ReadLine();

            switch(commandInput){
                case "0":
                    closeApp = true;
                    break;
                case "1":
                    Insert("TPX");
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":

                    break;
                default:
                    Console.WriteLine("\n================================================");
                    Console.WriteLine("\nCOMANDO INVÁLIDO ");
                    Console.WriteLine("\n================================================");
                    break;
            }
        }
    }
    public static void Insert(string parameter){

            Console.WriteLine("\n================================================");
            Console.WriteLine("\nINFORME O  ARQUIVO .TXT COM OS E2E DA "+parameter);
            Console.WriteLine("\n================================================");

            string? commandInput2 = Console.ReadLine();

            try
            {
                var lines = File.ReadAllLines(commandInput2 == null ? "" : commandInput2);
                foreach (var line in lines)
                    E2E_Repository.InsertE2e(line, parameter);

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n================================================");
                Console.WriteLine("\n"+ex.Message);
                Console.WriteLine("\n================================================");
            }
    }

}
