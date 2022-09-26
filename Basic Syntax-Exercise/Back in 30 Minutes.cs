using System;

namespace Back__in__30__Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) +30;

            if (minutes > 59 )
            {
                minutes -= 60;
                hours = hours + 1;
                
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2} ");
           
            
            

        }
    }
}
