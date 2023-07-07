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
        public string imie;
        public int wiek;
        public double wzrost;
        public double waga;
        public string plec;

        public void GetUserData()
        {
            do
            {
                Console.Write("Podaj wiek (15-80 lat): ");
                string wiekTekst = Console.ReadLine();
                if (!int.TryParse(wiekTekst, out wiek))
                {
                    Console.WriteLine("Niepoprawny format wieku. Spróbuj ponownie.");
                    continue;
                }
                if (wiek < 15 || wiek > 80)
                {
                    Console.WriteLine("Wiek musi być między 15 a 80 lat. Spróbuj ponownie.");
                }
            } while (wiek < 15 || wiek > 80);

            do
            {
                Console.Write("Podaj wzrost (120-200 cm): ");
                string wzrostTekst = Console.ReadLine();
                if (!double.TryParse(wzrostTekst, out wzrost))
                {
                    Console.WriteLine("Niepoprawny format wzrostu. Spróbuj ponownie.");
                    continue;
                }
                if (wzrost < 120 || wzrost > 200)
                {
                    Console.WriteLine("Wzrost powinien się zawierać pomiędzy 140cm a 200cm. Spróbuj ponownie.");
                }
            } while (wzrost < 120 || wzrost > 200);

            do
            {
                Console.Write("Podaj wagę (40-120 kg): ");
                string wagaTekst = Console.ReadLine();
                if (!double.TryParse(wagaTekst, out waga))
                {
                    Console.WriteLine("Niepoprawny format wagi. Spróbuj ponownie.");
                    continue;
                }
                if (waga < 40 || waga > 120)
                {
                    Console.WriteLine("Waga musi być między 40 a 120 kg. Spróbuj ponownie.");
                }
            } while (waga < 40 || waga > 120);

            do
            {
                Console.Write("Podaj płeć (k/m): ");
                plec = Console.ReadLine().ToLower();
                if (plec != "k" && plec != "m")
                {
                    Console.WriteLine("Niepoprawna płeć. Spróbuj ponownie.");
                }
            } while (plec != "k" && plec != "m");

            Console.WriteLine("Dane zostały zapisane.");
            Console.WriteLine();
        }

        public void BMR1()
        { 
            if (plec == "k")
            {
                double BMR = 655 + waga * 9.6 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + waga * 13.7 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
        }

        public void BMR2()
        {
            if (plec == "k")
            {
                double BMR = 655 + waga * 9.6 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + waga * 13.7 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();
            }
        }

        public void BMR3()
        {
            if (plec == "k")
            {
                double BMR = 655 + waga * 9.6 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
            else
            {
                double BMR = 66 + waga * 13.7 + wzrost * 5 - wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();
            }
        }

        public void BMI()
        {
            double wzrostm2 = wzrost * 0.01;
            double BMI = waga/(wzrostm2 * wzrostm2);
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
          
        public int GetUserChoice()
        {
            Console.WriteLine("1. Redukcja wagi");
            Console.WriteLine("2. Utrzymanie wagi");
            Console.WriteLine("3. Zwiększenie wagi");

            int opcja;
            bool poprawnyWybor = false;

            do
            {
                string opcjaTekst = Console.ReadLine();
                if (!int.TryParse(opcjaTekst, out opcja))
                {
                    Console.WriteLine("Niepoprawny format. Spróbuj ponownie.");
                    continue;
                }

                if (opcja < 1 || opcja > 3)
                {
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                }
                else
                {
                    poprawnyWybor = true;
                }
            } while (!poprawnyWybor);

            return opcja;
        }
    }
    
}