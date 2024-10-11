using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Building
    {
        string adress;
        double lenght;
        double width;
        double height;

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Ошибка! Адрес не может быть пустым!");
                }
                else
                {
                    adress = value;
                }
            }
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка! Длина не может быть отрицательной!");
                }
                else
                {
                    lenght = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка! Ширина не может быть отрицательной!");
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка! Высота не может быть отрицательной!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public Building(string adress, double lenght, double width, double height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"Здание располагается по адресу {adress}, имеет длину {lenght}, ширину {width}, высоту {height}.";
        }
    }
}
