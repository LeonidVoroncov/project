using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace DayWeek
{
    public class DaysWeek : IEnumerator
    {
        public static string [] arrayDays =  { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        int index = -1;

        string a;

        public bool MoveNext()
        {
            index ++;
            return (index < arrayDays.Length);
        }

        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get
            {
                a = arrayDays[index];
                return a;
            }
        }
    }


    public class TransferDaysArray : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return DaysWeek.arrayDays.GetEnumerator();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TransferDaysArray dayWeek = new TransferDaysArray();
            foreach(var arrayDays in dayWeek)
            {
                Console.WriteLine($"День недели: {arrayDays}");
            }
            Console.ReadKey();
        }
    }
}
