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
            string name, mark;
            double price;
            int serieNumber, d, m, a;

            StartApp(out name, out price, out serieNumber, out mark, out d, out m, out a);

            //Criando o objeto:
            Record equips = new Record(name, price, serieNumber, mark, d, m, a);

            int option = -1;

            //Repetição até que o usuário queira sair do app:
            do
            {
                Console.Clear();
                OutPutUserOptions();
                option = int.Parse(Console.ReadLine());
                OptionMethods(equips, option);
            } while (option != 8);
        }

        private static void StartApp(out string name, out double price, out int serieNumber, out string mark, out int d, out int m, out int a)
        {
            do
            {
                Console.WriteLine("Digite o nome do primeiro equipamento (precisa ter mais que 6 caracteres): ");
                name = Console.ReadLine();
            } while (name.Length < 6);
            Console.WriteLine("Quanto ele custou (digite somente o valor numérico)?");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de série do equipamento: ");
            serieNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a marca do equipamento? ");
            mark = Console.ReadLine();
            Console.WriteLine("Digite o dia de fabricação:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano:");
            a = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }

        private static void OutPutUserOptions()
        {
            Console.WriteLine("Digite o número da opção que deseja realizar:\n0 - Visualizar equipamentos\n1 - Adicionar novo equipamento\n" +
                                "2 - Alterar informações de um equipamento já registrado\n3 - Remover um equipamento\n" +
                                "4 - Agendar chamado de manutenção\n5 - Ver manutenções agendadas\n6 - Editar chamado de manutenção\n" +
                                "7 - Remover chamado de manutenção\n8 - Sair");
        }

        private static void OptionMethods(Record equips, int option)
        {
            if (option == 0) { equips.ShowEquipments(); }

            else if (option == 1) { equips.AddEquips(); }

            else if (option == 2) { equips.EditEquip(); }

            else if (option == 3) { equips.Remove(); }

            else if (option == 4) { equips.AddKeeping(); }

            else if (option == 5) { equips.ShowKeeping(); }

            else if (option == 6) { equips.EditKeeping(); }

            else if (option == 7) { equips.RemoveKeeping(); }
        }
    }
}
