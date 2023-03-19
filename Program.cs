
using System;
using System.Collections.Generic;
using System.Linq;

namespace pr1
{
    class Program : Pacient
    {
        static void Main(string[] args)
        {
            string again = "yes";
            while (again == "yes")
            {
                List<Pacient> pacients = new List<Pacient>();
            var summerList = new List<string>();
            var springList = new List<string>();
            Pacient pacient1 = new Pacient();
            pacient1.FIO = "Леонель Меси";
            pacient1.Day = 18;
            pacient1.Month = 8;
            pacient1.Year = 2005;
            pacients.Add(pacient1);


            Pacient pacient2 = new Pacient();
            pacient2.FIO = "Аафва Аваафв";
            pacient2.Day = 10;
            pacient2.Month = 4;
            pacient2.Year = 2003;
            pacients.Add(pacient2);

            Console.WriteLine("Нажмите 1 если хотите просмотреть данные о " + pacient1.FIO + " или 2 если хотите посмотреть информацию о " + pacient2.FIO);
            int choosepacients = Convert.ToInt32(Console.ReadLine());
            if (!string.IsNullOrEmpty(pacient1.FIO) && choosepacients == 1)
            {
                Console.WriteLine("Инициалы пациента:\t " + pacient1.FIO);
                Console.WriteLine("Месяц рождения:\t\t " + pacient1.ToString());
                Console.WriteLine("Возраст: \t\t " + pacient1.AgeResult(pacient1));

            }
            else if (!string.IsNullOrEmpty(pacient2.FIO) && choosepacients == 2)
            {
                Console.WriteLine("Инициалы пациента:\t " + pacient2.FIO);
                Console.WriteLine("Месяц рождения:\t\t " + pacient2.ToString());
                Console.WriteLine("Возраст: \t\t " + pacient2.AgeResult(pacient2));

            }

            Console.WriteLine("Нажмите на кнопку 1 если нужно вывести список весенных дат рождения или 2 если нужно вывести летние");
            int r1 = Convert.ToInt32(Console.ReadLine());
            if (r1 == 1)
            {
                var spring = pacients.Where(s => s.Year >= 1990 & s.Year <= 2005 & s.Month >= 3 & s.Month <= 5).OrderBy(s => s);
                foreach (Pacient p in spring)
                {
                    Console.WriteLine("Весенние даты рождения: " + p.DateOfBirth(p));

                }
            }
            else if (r1 == 2)
            {
                var summer = pacients.Where(s => s.Month >= 6 & s.Month <= 8).OrderBy(s => s);
                foreach (Pacient p2 in summer)
                {

                    Console.WriteLine("Летние даты рождения: " + p2.DateOfBirth(p2));

                }
            }
                Console.WriteLine("Вы хотите продолжить работу с программой? (yes/no)");
                again = Console.ReadLine();

            }
            
        }
    }
}

