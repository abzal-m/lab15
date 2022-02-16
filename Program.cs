using System;

namespace lab15
{
    class Program
    {
        static string[] resultActionList = new string[] { };
        static void Main(string[] args)
        {
            Console.WriteLine(" # | Действие");
            Console.WriteLine("---|---------------------------------");
            Console.WriteLine(" 1 | Начало дня");

            int action1 = ChooseVariant(1, 2);
            switch (action1)
            {
                case 1:
                    ChooseAction(1);
                    break;
                case 2:
                    ChooseAction(2);
                    break;
                default:
                    break;
            }
            if(action1 == 1)
            {
                int action2 = ChooseVariant(1, 10);
                switch(action2)
                {
                    case 1: case 2:case 3:case 4:case 5:case 6:case 7:
                        ChooseAction(3);
                        break;
                    case 8:case 9:case 10:
                        int action3 = ChooseVariant(1, 6);
                        switch(action3)
                        {
                        case 1:case 2:case 3:case 4:
                            ChooseAction(4);
                            break;
                        case 5:case 6:
                            ChooseAction(5);
                            break;
                        default:
                        break;
                        }
                    break;
                    default:
                    break;
                }
            }
            else
            {
                int action3 = ChooseVariant(1, 6);
                switch(action3)
                {
                    case 1:case 2:case 3:case 4:
                        ChooseAction(4);
                        break;
                    case 5:case 6:
                        ChooseAction(5);
                        break;
                    default:
                    break;
                }
            }

            int action4 = ChooseVariant(1, 12);
            switch(action4)
            {
                case 1: case 2:case 3:case 4:case 5:case 6:case 7:case 8:
                    ChooseAction(6);
                    break;
                case 9:case 10:case 11:case 12:
                    int action5 = ChooseVariant(1, 4);
                    switch(action5)
                    {
                        case 1:
                            ChooseAction(7);
                            break;
                        case 2:case 3:case 4:
                            ChooseAction(8);
                            break;
                        default:
                        break;
                    }
                break;
                default:
                break;
            }
            int action6 = ChooseVariant(1, 5);
            switch(action6)
            {
                case 1: case 2:
                    ChooseAction(9);
                    int action7 = ChooseVariant(1, 8);
                    switch(action7)
                        {
                            case 1: case 2:
                                ChooseAction(10);
                                int action8 = ChooseVariant(1, 8);
                                switch(action8)
                                {
                                    case 1: case 2:
                                        ChooseAction(13);
                                        break;
                                    case 3:case 4:case 5:case 6:case 7:case 8:
                                        ChooseAction(14);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 3:case 4:case 5:case 6:case 7:case 8:
                                ChooseAction(11);
                                int action9 = ChooseVariant(1, 2);
                                switch (action9)
                                {
                                    case 1:
                                        ChooseAction(13);
                                        break;
                                    case 2:
                                        ChooseAction(14);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                case 3:case 4:case 5:
                    ChooseAction(12);
                    int action10 = ChooseVariant(1, 8);
                    switch(action10)
                    {
                        case 1: case 2:case 3:case 4:case 5:
                            ChooseAction(13);
                            break;
                        case 6:case 7:case 8:
                            ChooseAction(14);
                            break;
                        default:
                            break;
                    }
                    break;


            }

           
            PrintResultActionList(resultActionList);
        }

        static string[] ChooseAction(int b)
        {
            string a = variants[b];
            Array.Resize(ref resultActionList, resultActionList.Length + 1);
            resultActionList[resultActionList.Length - 1] = a;
            return resultActionList;
        }

        static string[] PrintResultActionList(string[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($" {i + 2} | {resultActionList[i]}");
            }
            return a;
        }

        static int ChooseVariant(int a, int b)
        {
            Random randomLevel = new Random();
            int initialLevel = randomLevel.Next(a, b + 1);
            return initialLevel;
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
