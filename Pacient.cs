using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Pacient
    {
        private string _fio;
        private int _year;
        private int _month;
        private int _day;


        public string FIO
        {
            get { return _fio; }
            set
            {
                if (value.IndexOf(' ') > -1)
                {

                    _fio = value;

                }
                else
                {
                    Console.WriteLine("Введенные инициалы неккоректны");


                }
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1980)
                {
                    _year = value;
                }
                else
                {

                    throw new ArgumentException("Год неккоректен");
                }
            }
        }
        public int Month
        {
            get { return _month; }
            set
            {
                if (value <= 12)
                {

                    _month = value;
                }
                else
                {
                    throw new ArgumentException("Месяц неккоректен");
                }
            }
        }
        public int Day
        {
            get { return _day; }
            set
            {
                if (value <= 31)
                {

                    _day = value;
                }
                else
                {
                    throw new ArgumentException("День неккоректен");
                }
            }
        }
        public override string ToString()
        {
            var tmp = new DateTime(1, Month, 1);
            return tmp.ToString("MMMM");
        }
        public int AgeResult(Pacient pacient)
        {
            int age = DateTime.Now.Year - pacient._year;
            if (DateTime.Now.DayOfYear < new DateTime(pacient.Year, pacient.Month, pacient.Day).DayOfYear)
                age--;
            return age;
        }
        public string DateOfBirth(Pacient pacient)
        {
            string dateofbirth = pacient.Day.ToString() + "." + pacient.Month.ToString() + "." + pacient.Year.ToString();
            return dateofbirth;
        }
    }
}