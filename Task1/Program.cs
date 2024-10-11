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
            Console.WriteLine("Моделируем здания!\n\n");
            try
            {
                Console.WriteLine("Введите адрес:");
                string adress = Console.ReadLine();
                Console.WriteLine("Введите длину здания:");
                double lenght = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ширину здания:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту здания:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите кол-во этажей:");
                int floors = Convert.ToInt32(Console.ReadLine());
                MultiBuilding multiBuilding = new MultiBuilding(adress, lenght, width, height, floors);
                Console.WriteLine(multiBuilding.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
