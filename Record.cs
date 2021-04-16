using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentsApp.ConsoleApp
{
    class Record
    {
        const int nmbrOfRegisters = 100;
        private string[] name = new string [nmbrOfRegisters];
        private double[] price = new double[nmbrOfRegisters];
        private int[] serienumber = new int [nmbrOfRegisters];
        private string[] factoryname = new string[nmbrOfRegisters];
        private DateTime[] manufacturingDate = new DateTime[nmbrOfRegisters];
        private int counter = 0;

        private string[] callKeeping = new string[nmbrOfRegisters];
        private string[] keepingDescription = new string[nmbrOfRegisters];
        private DateTime[] keepingDate = new DateTime[nmbrOfRegisters];


        public Record(string name, double price, int serienumber, string factoryname, int day, int month, int year)
        {
            this.Name[0] = name;
            this.price[0] = price;
            this.Serienumber[0] = serienumber;
            this.Factoryname[0] = factoryname;
            this.Today[0] = new DateTime(year, month, day);

        }


        public void AddEquips()
        {
            this.counter++;
            Console.WriteLine("Nome do produto:");
            Name[counter] = Console.ReadLine();

            Console.WriteLine("Preço do produto:");
            Price[counter] = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de série do produto:");
            Serienumber[counter] = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do fabricante do produto:");
            Factoryname[counter] = (Console.ReadLine());

            Console.WriteLine("Dia de fabricação:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano:");
            int year = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Today[counter] = new DateTime(year, month, day);
        }

        public void ShowEquipments()
        {
            Console.WriteLine("Digite o índice do equipamento que deseja visualizar:");
            for (int i = 0; i < nmbrOfRegisters; i++)
            {
                if (Name[i] != null) {

                    Console.WriteLine($"{Name[i]} - {i}");

                    int index = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Nome: {Name[index]}");
                    Console.WriteLine($"Preço: {Price[index]}");
                    Console.WriteLine($"Nome do fabricane: {Factoryname[index]}");
                    Console.WriteLine($"Data de fabricação: {ManufacturingDate[index]}");
                }
                
            }
            
        }

        public void ChangeEquipConfigs()
        {
            Console.WriteLine("Digite o índice do equipamento que deseja alterar:");
            for (int i = 0; i < name.Length; i++)
            {
                if (Name[i] != null)
                {
                    Console.WriteLine($"{Name[i]} - {i}");
                }
            }

            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite um número para alterar a característica:" +
                $" \n1 - Nome\n2 - Price\n3- Número de série\n4 - Marca fabricante\n5 Data de fabricação\n0 -sair");
            int check = int.Parse(Console.ReadLine());
            if (check == 1)
            {
                Console.WriteLine("Nome do produto:");
                Name[index] = Console.ReadLine();
            }

            else if (check == 2)
            {
                Console.WriteLine("Preço do produto:");
                Price[index] = double.Parse(Console.ReadLine());
            }
            else if (check == 3)
            {
                Console.WriteLine("Número de série do produto:");
                Serienumber[index] = int.Parse(Console.ReadLine());
            }
            else if (check == 4)
            {

                Console.WriteLine("Nome do fabricante do produto:");
                Factoryname[index] = (Console.ReadLine());
            }

            else if (check == 5)
            {
                Console.WriteLine("Dia de fabricação:");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Mês:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano:");
                int year = int.Parse(Console.ReadLine());
                Console.ReadLine();
                Today[index] = new DateTime(year, month, day);
            }
        }

        public void Remove()
        {
            Console.WriteLine("Digite o indice do produto que deseja remover: ");
            for (int i = 0; i < name.Length; i++)
            {
                if (Name[i] != null)
                {
                    Console.WriteLine($"{Name[i]} - {i}");
                }
            }


            int index = int.Parse(Console.ReadLine());
            Name[index] = null;
            Console.WriteLine("Equipamento removido");
        }

        public void AddKeeping()
        {
            Console.WriteLine("Digite o índice do equipamento que deseja agendar uma manutenção:");
            for (int i = 0; i < name.Length; i++)
            {
                if (Name[i] != null) {
                    Console.WriteLine($"{Name[i]} - {i}");
                }
            }

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"A manutenção será marcada para o equipamento { Name[index]}");

            Console.WriteLine("Digite um título para o chamado:");
            CallKeeping[index] = Console.ReadLine();

            Console.WriteLine("Digite uma descrição para o chamado:");
            KeepingDescription[index] = Console.ReadLine();

            Console.WriteLine("Digite o dia para a manutenção: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite e o ano: ");
            int year = int.Parse(Console.ReadLine());

            KeepingDate[index] = new DateTime(year, month, day);

        }

        public void ShowKeeping()
        {
            int cont = 0;

            for (int j = 0; j < CallKeeping.Length; j++)
            {
                if (CallKeeping[j] == null)
                {
                    cont++;
                }
            }
            if (cont != callKeeping.Length)
            {
                Console.WriteLine("Digite o índice do equipamento que deseja visualizar o chamado:");
                for (int i = 0; i < name.Length; i++)
                {
                    if (Name[i] != null)
                    {
                        Console.WriteLine($"{Name[i]} - {i}");
                    }
                }

                int index = int.Parse(Console.ReadLine());

                Console.WriteLine(CallKeeping[index]);
                Console.WriteLine(KeepingDescription[index]);
                Console.WriteLine($"Data de abertura {KeepingDate[index]}");
                TimeSpan Calcdifference = (DateTime.Now).Subtract(KeepingDate[index]);
                int daysDifference = Convert.ToInt32(Calcdifference.TotalDays);
                Console.WriteLine($"Número de dias desde que a manutenção foi marcada: {daysDifference}");
            }
            else
            {
                Console.WriteLine("Você não tem manutenções agendadas.");
            }
        }

        public void EditKeeping()
        {
            Console.WriteLine("Digite o índice do equipamento que deseja editar a manutenção:");
            for (int i = 0; i < name.Length; i++)
            {
                if (Name[i] != null)
                {
                    Console.WriteLine($"{Name[i]} - {i}");
                }
            }

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"A manutenção será editada para o equipamento { Name[index]}");

            Console.WriteLine("O que deseja alterar: \n1 - Título \n2 - Descrição\n3 Data");
            int checker = int.Parse(Console.ReadLine());
            if (checker == 1)
            {
                Console.WriteLine("Digite um título para o chamado:");
                CallKeeping[index] = Console.ReadLine();
            }

            else if (checker == 2)
            {
                Console.WriteLine("Digite uma descrição para o chamado:");
                KeepingDescription[index] = Console.ReadLine();
            }

            else if (checker == 3)
            {
                Console.WriteLine("Digite o dia para a manutenção: ");
                int day = int.Parse(Console.ReadLine());


                Console.WriteLine("O mês: ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite e o ano: ");
                int year = int.Parse(Console.ReadLine());

                KeepingDate[index] = new DateTime(year, month, day);
            }
        }

        public void RemoveKeeping()
        {
            Console.WriteLine("Digite o índice do equipamento que deseja remover o chamado:");
            for (int i = 0; i < name.Length; i++)
            {
                if (Name[i] != null)
                {
                    Console.WriteLine($"{Name[i]} - {i}");
                }
            }
            int index = int.Parse(Console.ReadLine());

            CallKeeping[index] = null;
        }



        public string[] Name { get => name; set => name = value; }
        public double[] Price { get => price; set => price = value; }
        public int[] Serienumber { get => serienumber; set => serienumber = value; }
        public string[] Factoryname { get => factoryname; set => factoryname = value; }
        public DateTime[] Today { get => ManufacturingDate; set => ManufacturingDate = value; }
        public string[] CallKeeping { get => callKeeping; set => callKeeping = value; }
        public string[] KeepingDescription { get => keepingDescription; set => keepingDescription = value; }
        public DateTime[] KeepingDate { get => keepingDate; set => keepingDate = value; }
        public DateTime[] ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
    }
}
