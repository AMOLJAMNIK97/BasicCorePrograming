// See https://aka.ms/new-console-template for more information
using BasicCore_Programing;
using System.Security.Cryptography.X509Certificates;
{
      
    
        while (true)
        {
            Console.WriteLine("1.FlipCoin 2.\n Enter year 3.\n Enter a Power");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Leap_Year leap = new Leap_Year();
                    leap.FindLeap();
                    break;
                case 2:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CheckHeadTail();
                    break;
                case 3:
                Power power = new Power();
                power.FindPower();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }

        }
    
}
