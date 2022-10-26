using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите 1 - кошка \nНажмите 2 - собака");
            Cat cat = new Cat("Кошка", "Мяу");
            Dog dog = new Dog("Собака", "Гав");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                cat.Say();
                Console.WriteLine("Нажмите 1 - свойсва");
                int options = Convert.ToInt32(Console.ReadLine());
                if (options<1 || options>1)
                {
                    options = 1;
                }
                else if (options == 1)
                {
                    cat.ShowInfo();
                }
            }
            else if (choice == 2)
            {
                dog.Say();
                Console.WriteLine("Нажмите 1 - свойсва");
                int options = Convert.ToInt32(Console.ReadLine());
                if (options < 1 || options > 1)
                {
                    options = 1;
                }
                else if (options == 1)
                {
                    dog.ShowInfo();
                }
            }
         
            Console.ReadLine();
        }
    }
}
