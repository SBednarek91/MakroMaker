using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace MakroMaker
{
    public class UserData
    {
        public int age;
        public double height;
        public double weight;
        public string sex;

        /*wczytywanie danych użytkownika*/
       /* walidacja danych użytkownika*/

        public void GetUserData()
        {
            do
            {
                Console.Write("Podaj wiek (15-80 lat): ");
                string ageTekst = Console.ReadLine();
                if (!int.TryParse(ageTekst, out age))
                {
                    Console.WriteLine("Niepoprawny format wieku. Spróbuj ponownie.");
                    continue;
                }
                if (age < 15 || age > 80)
                {
                    Console.WriteLine("Wiek musi być między 15 a 80 lat. Spróbuj ponownie.");
                }
            } while (age < 15 || age > 80);

            do
            {
                Console.Write("Podaj wzrost (120-200 cm): ");
                string heightTekst = Console.ReadLine();
                if (!double.TryParse(heightTekst, out height))
                {
                    Console.WriteLine("Niepoprawny format wzrostu. Spróbuj ponownie.");
                    continue;
                }
                if (height < 120 || height > 200)
                {
                    Console.WriteLine("Wzrost powinien się zawierać pomiędzy 140cm a 200cm. Spróbuj ponownie.");
                }
            } while (height < 120 || height > 200);

            do
            {
                Console.Write("Podaj wagę (40-120 kg): ");
                string weightTekst = Console.ReadLine();
                if (!double.TryParse(weightTekst, out weight))
                {
                    Console.WriteLine("Niepoprawny format wagi. Spróbuj ponownie.");
                    continue;
                }
                if (weight < 40 || weight > 120)
                {
                    Console.WriteLine("Waga musi być między 40 a 120 kg. Spróbuj ponownie.");
                }
            } while (weight < 40 || weight > 120);

            do
            {
                Console.Write("Podaj płeć (k/m): ");
                sex = Console.ReadLine().ToLower();
                if (sex != "k" && sex != "m")
                {
                    Console.WriteLine("Niepoprawna płeć. Spróbuj ponownie.");
                }
            } while (sex != "k" && sex != "m");

            Console.WriteLine("Dane zostały zapisane.");
            Console.WriteLine();
        }

        /*metoda na wyliczanie zapotrzebowania -300*/

        public void BMR1()
        { 
            if (sex == "k")
            {
                double BMR = 655 + weight * 9.6 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + weight * 13.7 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
        }

        /*metoda na wyliczanie zapotrzebowania zerowego*/

        public void BMR2()
        {
            if (sex == "k")
            {
                double BMR = 655 + weight * 9.6 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + weight * 13.7 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();
            }
        }


        /*metoda na wyliczanie zapotrzebowania +300*/
        public void BMR3()
        {
            if (sex == "k")
            {
                double BMR = 655 + weight * 9.6 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + weight * 13.7 + height * 5 - age * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
        }


        /*metoda na wyliczanie BMI 
        zmiana koloru BMI wg zakresu*/

        public void BMI()
        {
            double wzrostm2 = height * 0.01;
            double BMI = weight /(wzrostm2 * wzrostm2);
            double zaokragloneBMI = Math.Round(BMI, 1);
            
            if (BMI < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            

        }
          
        /*wybor opcji kcal uzytkownika */

        public int GetUserChoice()
        {
            Console.WriteLine("1. Redukcja wagi");
            Console.WriteLine("2. Utrzymanie wagi");
            Console.WriteLine("3. Zwiększenie wagi");

            int option;
            bool istrue = false;

            do
            {
                string optionTekst = Console.ReadLine();
                if (!int.TryParse(optionTekst, out option))
                {
                    Console.WriteLine("Niepoprawny format. Spróbuj ponownie.");
                    continue;
                }

                if (option < 1 || option > 3)
                {
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                }
                else
                {
                    istrue = true;
                }
            } while (!istrue);

            return option;
        }
    }
    
}