using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProg.Entities
{
    class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract()
        {
            //padrão
        }
        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            Data = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
