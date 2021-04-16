using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentsApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do primeiro equipamento: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quanto ele custou (digite somente o valor numérico)?");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de série do equipamento: ");
            int serieNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a marca do equipamento? ");
            string mark = Console.ReadLine();

            Console.WriteLine("Digite o dia de fabricação:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano:");
            int a = int.Parse(Console.ReadLine());
            Console.ReadLine();

            Record equips = new Record(name, price, serieNumber, mark, d, m, a);

            int option = -1;
            do
            {
                Console.WriteLine("Digite o número da opção que deseja realizar:\n0 - Visualizar equipamentos\n1 - Adicionar novo equipamento\n" +
                    "2 - Alterar informações de um equipamento já registrado\n3 - Remover um equipamento\n" +
                    "4 - Agendar chamado de manutenção\n5 - Ver manutenções agendadas\n6 - Editar chamado de manutenção\n" +
                    "7 - Remover chamado de manutenção\n8 - Sair");
                option = int.Parse(Console.ReadLine());
                if (option == 0) { equips.ShowEquipments(); }

                else if (option == 1) { equips.AddEquips(); }

                else if (option == 2) { equips.ChangeEquipConfigs(); }

                else if (option == 3) { equips.Remove(); }

                else if (option == 4) { equips.AddKeeping(); }

                else if (option == 5) { equips.ShowKeeping(); }

                else if (option == 6) { equips.EditKeeping(); }

                else if (option == 7) { equips.RemoveKeeping(); }
                
            } while (option != 8);
        }
    }
}
