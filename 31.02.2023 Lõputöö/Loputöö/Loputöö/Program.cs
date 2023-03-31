using Loputöö;
using System.Diagnostics;

namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LÕPUTÖÖ");

            Console.WriteLine("VALI ÜLESANNE");
            Console.WriteLine("1. Ülesanne");
            Console.WriteLine("2. Ülesanne");
            Console.WriteLine("3. Ülesanne");

            Console.WriteLine("\n\nPalun tee valik numbriga: ");

            byte selection = byte.Parse(Console.ReadLine());



            switch (selection)
            {
                case 1:
                    Console.WriteLine("------------ÜLESANNE 1 / WHERE----------------");
                    WhereLINQ();

                    Console.WriteLine("------------ÜLESANNE 1 / ANY----------------");
                    AllAndAnyLINQ();

                    Console.WriteLine("------------ÜLESANNE 1 / Contains----------------");
                    ContainsLINQ();

                    Console.WriteLine("------------ÜLESANNE 1 / Avarage----------------");
                    AvarageLINQ();
                    break;

                case 2:

                    Console.WriteLine("Palun sisesta Asukoht kuhu soovid file lisada: ");
                    string filePath = Console.ReadLine();

                    if (filePath == "C:/Users/opilane/Desktop/WriteToFile.txt")
                    {
                        Console.WriteLine("Kirjuta faili läbi konsooli");
                        string inputText = Console.ReadLine();
                        File.WriteAllText(filePath, inputText);

                    }

                    else
                    {
                        try
                        {
                            Console.WriteLine("SEE OLI JU VALE KOHT!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR");
                        }
                    }


                    break;

                case 3:

                    Console.WriteLine("Ülesanne 3 Püramiid");
                    Console.WriteLine("Sisesta püramiidi suurus (Ära sisesta üle 4): ");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    int spc = rows + 4 - 1;
                    int t=1;

                    for (int i = 1; i <= rows; i++)
                    {
                        Console.Write("\n");
                        for (int k = spc; k >= 1; k--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("{0} ", t++);
                        }
                        spc--;
                    }

                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
        }

        public static void WhereLINQ()
        {
            var filteredResult = PeopleList.people.Where((s, i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            foreach (var people in filteredResult)
            {
                Console.WriteLine(people.Name);
            }
        }
        public static void AllAndAnyLINQ()
        {

            bool isAnyPersonTeenAger = PeopleList.people
                .Any(x => x.Age < 12);
            //kasv]i [ks andmerida vastab tingimusele
            Console.WriteLine(isAnyPersonTeenAger);
        }

        public static void ContainsLINQ()
        {
            //pärib, kas on number 10 numbrite nimekirjas olemas
            bool result = NumberList.numberList.Contains(10);

            Console.WriteLine(result);
        }
        public static void AvarageLINQ()
        {

            var avarageResult = PeopleList.people
                .Average(x => x.Age);

            Console.WriteLine("Keskmine vanus on: " + avarageResult);
        }
    }
}