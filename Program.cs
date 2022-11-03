using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020,2));
            Console.WriteLine(IsWeeKend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());



            /*var timeSpan = new TimeSpan(1);
            Console.WriteLine(timeSpan);

            var timeSpanHoraMinutoSegundos = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundos);

            var timeSpanDiaHoraMinutoSegundos = new TimeSpan(3, 5, 12, 8);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos);

            var timeSpanDiaHoraMinutoSegundosMilessegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundosMilessegundo);

            
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos - timeSpanDiaHoraMinutoSegundos);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundos.Add(new TimeSpan(12, 0, 0)));*/



            //////////////////////////////
            /*var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dateTime.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneAustralia);
            Console.WriteLine(horaAustralia);


            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone));
                Console.WriteLine("-----------");
            }*/

        }

        static bool IsWeeKend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}