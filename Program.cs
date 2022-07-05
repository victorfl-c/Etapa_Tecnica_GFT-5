using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o valor do veículo: ");
            double vehicleValue = double.Parse(Console.ReadLine());
            double vehicleWithDiscount = vehicleValue - (vehicleValue * 20/100);
            Console.WriteLine("Deseja Parcelar? ");
            Console.WriteLine("Digite S para Sim");
            Console.WriteLine("Digite N para não");
            string question = Console.ReadLine().ToUpper();
            switch(question)
            {
                case "N" :
                Console.WriteLine("O valor do veículo à vista com desconto é de : " + vehicleWithDiscount);break;
                case "S" :
                Console.WriteLine("Em quantas vezes deseja parcelar?");
                Console.WriteLine("Digite 1 - seis vezes");
                Console.WriteLine("Digite 2 - doze vezes");
                Console.WriteLine("Digite 3 - dezoito vezes");
                Console.WriteLine("Digite 4 - vinte e quatro vezes");
                Console.WriteLine("Digite 5 - trinta vezes");
                int choice =  int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    var vehicleWithAcress = vehicleValue + ( vehicleValue * 3/100);
                    Console.WriteLine("O valor do veículo parcelado é de: " + vehicleWithAcress);
                }
                else if(choice == 2)
                {
                    var vehicleWithAcress = vehicleValue + ( vehicleValue * 6/100);
                    Console.WriteLine("O valor do veículo parcelado é de: " + vehicleWithAcress);
                }
                else if(choice == 3)
                {
                    var vehicleWithAcress = vehicleValue + ( vehicleValue * 9/100);
                    Console.WriteLine("O valor do veículo parcelado é de: " + vehicleWithAcress);
                }
                else if(choice == 4)
                {
                    var vehicleWithAcress = vehicleValue + ( vehicleValue * 12/100);
                    Console.WriteLine("O valor do veículo parcelado é de: " + vehicleWithAcress);
                }
                else if(choice == 5)
                {
                    var vehicleWithAcress = vehicleValue + ( vehicleValue * 15/100);
                    Console.WriteLine("O valor do veículo parcelado é de: " + vehicleWithAcress);
                }
                else
                Console.WriteLine("Escolha uma opção valida");break;
                default : return;
            } 
        }
    }
}