using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding:Building
    {
        int floors;

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка! Количество этажей не может быть отрицательным!");
                }
                else
                {
                    floors = value;
                }
            }
        }
        public MultiBuilding(string adress, double length, double width, double height, int floors):base(adress, length, width, height)
        {
            Floors = floors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" Количество этажей в здании равно {floors}!";
            return result;
        }
    }
}
