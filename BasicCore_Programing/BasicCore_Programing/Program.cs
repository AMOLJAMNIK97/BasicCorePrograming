// See https://aka.ms/new-console-template for more information
using BasicCore_Programing;
{

    while (true)
    {
        Console.WriteLine("Enter year");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Leap_Year leap = new Leap_Year ();
                leap.FindLeap();
                break;
            default:
                Console.WriteLine("Please enter valid choice");
                break;
        }
    }
}
 
