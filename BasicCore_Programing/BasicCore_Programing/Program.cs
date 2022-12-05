// See https://aka.ms/new-console-template for more information
using BasicCore_Programing;
{
    while (true)
    {
        Console.WriteLine("1. FlipCoin");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                FlipCoin flipcoin = new FlipCoin();
                flipcoin.CheckHeadTail();
                break;
            default:
                Console.WriteLine("Please enter valid choice");
                break;
        }
    }
}
 
