using System;

namespace lab15
{
    class Program
    {
        static string[] resultActionList = new string[] { };
        static Random randomLevel = new Random();
        static void Main(string[] args)
        {
            ChooseAction(0);
            PrintResultActionList(resultActionList);
        }

        static void ChooseAction(int b)
        {
            string a = variants[b];
            Array.Resize(ref resultActionList, resultActionList.Length + 1);
            resultActionList[resultActionList.Length - 1] = a;

            switch(a)
            {
            case "Начало дня":
                int random = ChooseVariant(1, 2);
                if(random == 1)
                {
                    ChooseAction(1);
                }
                else
                {
                    ChooseAction(2);
                }
                break;
            case "Поднимаюсь с кровати с левой ноги":
                random = ChooseVariant(7, 10);
                if(random == 1)
                {
                    ChooseAction(3);
                }
                else
                {
                    goto case "Поднимаюсь с кровати с правой ноги";
                }
                break;
            case "Поднимаюсь с кровати с правой ноги":
                random = ChooseVariant(4, 6);
                if(random == 1)
                {
                    ChooseAction(4);
                }
                else
                {
                    ChooseAction(5);
                }
                break;
            case "Падаю с кровати" or "Пробежка по аллее" or "Физ. зарядка на балконе":
                random = ChooseVariant(8, 12);
                if(random == 1)
                {
                    ChooseAction(6);
                }
                else
                {
                    goto case "Готовлю плотный завтрак";
                }
                break;
            case "Готовлю плотный завтрак":
                random = ChooseVariant(1, 4);
                if(random == 1)
                {
                    ChooseAction(7);
                }
                else
                {
                    ChooseAction(8);
                }
                break;
            case "Варю крепкий кофе" or "Готовлю плотный завтрак" or "Достаю вчерашний салат":
                random = ChooseVariant(2, 5);
                if(random == 1)
                {
                    ChooseAction(9);
                }
                else
                {
                    ChooseAction(12);
                }
                break;
            case "Спустило колесо":
                random = ChooseVariant(2, 8);
                if(random == 1)
                {
                    ChooseAction(10);
                }
                else
                {
                    ChooseAction(11);
                }
                break;
            case "Добираюсь на работу пешком":
                random = ChooseVariant(2, 8);
                if(random == 1)
                {
                    ChooseAction(13);
                }
                else
                {
                    ChooseAction(14);
                }
                break;
            case "Добираюсь на работу на маршрутке":
                random = ChooseVariant(1, 2);
                if(random == 1)
                {
                    ChooseAction(13);
                }
                else
                {
                    ChooseAction(14);
                }
                break;
            case "Добираюсь на работу на своем авто":
                random = ChooseVariant(5, 8);
                if(random == 1)
                {
                    ChooseAction(13);
                }
                else
                {
                    ChooseAction(14);
                }
                break;
            case "Прихожу вовремя" or "Опаздываю на работу":
                ChooseAction(15);
                break;
            }
        }
        static void PrintResultActionList(string[] ActionList)
        {
            Console.WriteLine(" # | Действие");
            for(int i = 0; i < ActionList.Length; i++)
            {
                Console.WriteLine($" {i + 1} | {resultActionList[i]}");
            }
        }
        static void HappyCounter(int day)
        { 
            day = day - 1;
        }
        static int ChooseVariant(int maxForFirstVariant, int maxForSecondVariant)
        {
            int initialLevel = randomLevel.Next(1, maxForSecondVariant + 1);
            if (initialLevel <= maxForFirstVariant)
            {
                return 1;
            }
            return 2;
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
