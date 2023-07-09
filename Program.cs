using MakroMaker;
class Program
{
    static void Main(string[] args)
    {
        Messages welcome = new Messages();
        welcome.Welcomemessage();


        Console.WriteLine("Jak masz na imie?: ");
        string username = Console.ReadLine();
        Console.WriteLine();
        
        UserData userData = new UserData();
        userData.GetUserData();
        userData.BMI();

        Console.WriteLine(username + ", wybierz teraz jedną z następujących opcji:");
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
    }
}

    





