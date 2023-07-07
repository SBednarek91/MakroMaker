using MakroMaker;
class Program
{
    static void Main(string[] args)
    {
        Messages welcome = new Messages();
        welcome.Welcomemessage();


        Console.WriteLine("Jak masz na imie?: ");
        string imie = Console.ReadLine();
        Console.WriteLine();
        
        UserData userData = new UserData();
        userData.GetUserData();
        userData.BMI();

        Console.WriteLine(imie + ", wybierz teraz jedną z następujących opcji:");
        Console.WriteLine();

        UserData userchoice = new UserData();
        int wybranaopcja = userchoice.GetUserChoice();

      
        if (wybranaopcja == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Wybrano redukcję wagi");
            Console.WriteLine();

            userData.BMR1();

        }

        else if (wybranaopcja == 2)
        {
            Console.WriteLine("Wybrano utrzymanie wagi");
            Console.WriteLine();

            userData.BMR2();
        }

        else
        {
            Console.WriteLine("Wybrano zwiększenie wagi");
            Console.WriteLine();

            userData.BMR3();
        }
        

        /*UserData option = new UserData();
        int wybranaOpcja = option.GetUserChoice();*/

        /*if (wybranaOpcja == 1)
        {
            Console.WriteLine("Wybrano redukcję wagi");
            Console.WriteLine();
            UserData option1 = new UserData();
            option1.GetUserData();

            *//*double waga1 = option1.waga;
            double wzrost1 = option1.wzrost * 0.01;*//*
          
            if (option1.plec == "k")
            {
                *//*double BMR = 655 + option1.waga * 9.6 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);
               

                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR +" kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();*//*

                UserData processor = new UserData();
                processor.GetUserData();
                processor.BMI();



            }
            else
            {
                *//*double BMR = 66 + option1.waga * 13.7 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR - 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na redukcji wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();*//*

            }

            *//*double BMI = waga1/(wzrost1 * wzrost1);
            double zaokragloneBMI = Math.Round(BMI, 1);
            Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);*//*
            Console.WriteLine();

        }
        else if (wybranaOpcja == 2)
            {
            Console.WriteLine("Wybrano utrzymanie wagi");
            Console.WriteLine();
            UserData option1 = new UserData();
            option1.GetUserData();

            *//*double waga1 = option1.waga;
            double wzrost1 = option1.wzrost * 0.01;*//*
            if (option1.plec == "k")
            {
                *//*double BMR = 655 + option1.waga * 9.6 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
          
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();*//*

            }
            else
            {
               *//* double BMR = 66 + option1.waga * 13.7 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine();
*//*
            }

                *//*double BMI = waga1 / (wzrost1 * wzrost1);
                double zaokragloneBMI = Math.Round(BMI, 1);
                Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);*//*
                Console.WriteLine();

            }
        else 
        {
            Console.WriteLine("Wybrano zwiększenie wagi");
            Console.WriteLine();
            UserData option1 = new UserData();
            option1.GetUserData();

            *//*double waga1 = option1.waga;
            double wzrost1 = option1.wzrost * 0.01;*//*
            if (option1.plec == "k")
            {
               *//* double BMR = 655 + option1.waga * 9.6 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();*//*

            }
            else
            {
                *//*double BMR = 66 + option1.waga * 13.7 + option1.wzrost * 5 - option1.wiek * 6.76;
                double zaokragloneBMR = Math.Round(BMR);
                double BMR2 = zaokragloneBMR + 300;
                double zaokragloneBMR2 = Math.Round(BMR2);


                Console.WriteLine("Twoje podstawowe zapotrzebowanie wynosi: " + zaokragloneBMR + " kcal");
                Console.WriteLine("Twoje zapotrzebowanie na masie wynosi: " + zaokragloneBMR2 + " kcal");
                Console.WriteLine();*//*

            }

            *//*double BMI = waga1 / (wzrost1 * wzrost1);
            double zaokragloneBMI = Math.Round(BMI, 1);
            Console.WriteLine("Twoje BMI wynosi: " + zaokragloneBMI);*//*
            Console.WriteLine();
        }*/
            
    }
}

    





