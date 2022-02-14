using System;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" # | Действие");
            Console.WriteLine("---|---------------------------------");
            string buffer = variants[0];

            int plan = Randomizer(2);
            string list = string.Empty;
            switch(plan)
            {
            case 1:
                list = variants[plan];
                insert(ref buffer, list);
            break;
            case 2:
                list = variants[plan];
                insert(ref buffer, list);
            break;
            default:
                Console.WriteLine();
            break;
            }

            plan = Randomizer(10);

            PrintResultActionList(buffer);
        }

        static int Randomizer(int a)
        {
            Random randomLevel = new Random();
            int initialLevel = randomLevel.Next(1, a + 1);
            //Console.WriteLine(initialLevel);
            return initialLevel;
        }

        static string insert(ref string resultActionString, string value)
        {
            resultActionString = resultActionString + "; " + value;
            return resultActionString;
        }
        static string[] PrintResultActionList(string resultActionString)
        {
            string[] resultActionList = resultActionString.Split("; ");
            for(int i = 0; i < resultActionList.Length; i++)
            {
                Console.WriteLine($" {i + 1} | {resultActionList[i]}");
            }
            return resultActionList;
        }

        static string[] variants = {
            "Начало дня",
            "Поднимаюсь с кровати с левой ноги",
            "Поднимаюсь с кровати с правой ноги",
            "Падаю с кровати",
            "Пробежка по аллее",
            "Физ. зарядка на балконе",
            "Варю крепкий кофе",
            "Готовлю плотный завтрак",
            "Достаю вчерашний салат",
            "Спустило колесо",
            "Добираюсь на работу пешком",
            "Добираюсь на работу на маршрутке",
            "Добираюсь на работу на своем авто",
            "Прихожу вовремя",
            "Опаздываю на работу",
            "Конец"
        };

    }
}
