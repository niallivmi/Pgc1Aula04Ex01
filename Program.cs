//@niallivmi
using System;

namespace Pgc1Aula04Ex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Op, SN;
            float D, R;
            bool V;



            do
            {
                Console.WriteLine("          Conversão de Medidas");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                 Opções");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("| 1. Metros para quilômetros (M->KM)    |");
                Console.WriteLine("| 2. Quilômetros para metros (KM->M)    |");
                Console.WriteLine("| 3. Milhas para quilômetros (MI->KM)   |");
                Console.WriteLine("| 4. Quilômetros para milhas (KM->MI)   |");
                Console.WriteLine("| 5. Léguas para quilômetros (LÉGS->KM) |");
                Console.WriteLine("| 6. Quilômetros para léguas (KM->LÉGS) |");
                Console.WriteLine("| 7. Sair                               |");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("Qual opção deseja acessar?");
                Console.Write(">>");
                Op = Console.ReadLine();
                switch (Op)
                {
                    case "1":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D / 1000;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "2":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D * 1000;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "3":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D * 1.609f;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "4":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D / 1.609f;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "5":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D * 4.828f;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "6":
                        Console.Write("Digite a distância para a conversão: ");
                        D = float.Parse(Console.ReadLine());
                        R = D / 4.828f;
                        Console.WriteLine("A distância convertida é de: " + R);
                        break;
                    case "7":
                        Console.WriteLine("O programa será fechado!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
                Console.WriteLine("Deseja refazer o cálculo?");
                Console.Write(">>");
                SN = Console.ReadLine();

                V = (SN.ToUpper() == "S");
                Console.Clear();
            }
            while (V);
            {
                Console.WriteLine("O programa será fechado!");
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}