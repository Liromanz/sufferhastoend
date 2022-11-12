namespace Day_planner
{
    class Menu
    {
        private int Index;
        private string[] Massive;
        private string Start;
        public int perecl;

        public Menu(string start, string[] options)
        {
            Start = start;
            Massive = options;
            Index = 0;
            perecl = 0;

            ChangeDate(0);
            while (true)
            {
                strelocki();

            }
        }
        public void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine(Start);
            for (int i = 0; i < Massive.Length; i++)
            {
                string currentmassive = Massive[i];

                string strelocka;
                if (i == Index)
                {
                    strelocka = "->";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    strelocka = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{strelocka}{currentmassive}");
            }
            Console.ResetColor();
        }
        public void strelocki()
        {
            ConsoleKey keysI = Console.ReadKey(true).Key;
            do
            {
                if (keysI == ConsoleKey.UpArrow)
                {
                    Index--;
                    if (Index == -1)
                    {
                        Index = Massive.Length - 1;
                    }
                }
                else if (keysI == ConsoleKey.DownArrow)
                {
                    Index++;
                    if (Index == Massive.Length + 1)
                    {
                        Index = 0;
                    }
                }
                else if ((keysI == ConsoleKey.LeftArrow))
                {
                    perecl--;
                    if (perecl == -1)
                    {
                        perecl = 0;
                    }
                }
                else if (keysI == ConsoleKey.RightArrow)
                {
                    perecl++;
                    if (perecl == 4)
                    {
                        perecl = 3;
                    }
                }
                Console.Clear();
                ChangeDate(perecl);
                DisplayOptions();
                keysI = Console.ReadKey(true).Key;
            } while (keysI != ConsoleKey.Enter);
            ShowDescription(perecl, Index);
        }

        public void ChangeDate(int perecl)
        {
            if (perecl == 0)
            {
                Console.Clear();
                Start = "Напоминание на 07.11";
                Massive = new string[] { "1. Сделать практические", "2. Дочитать книгу 'Возвышение Хоруса'" };
            }
            else if (perecl == 1)
            {
                Console.Clear();
                Start = "Напоминание на 08.11";
                Massive = new string[] { "1. третья" };
            }
            else if (perecl == 2)
            {
                Console.Clear();
                Start = "Напоминание на 09.11";
                Massive = new string[] { "1. четвертая" };
            }
            else if (perecl == 3)
            {
                Console.Clear();
                Start = "Напоминание на 10.11";
                Massive = new string[] { "1. пятая" };
            }
        }

        public void ShowDescription(int perecl, int index)
        {
            if (perecl == 0 && index == 0)
            {
                Console.Clear();
                Start = "Напоминание на 07.11.22 по поводу практических работ";
                Massive = new string[] { "Выполнить практические по: Программированию(((, Дис.математике, Выс.математике", "Сделать до 09.11.22" };
            }
            else if (perecl == 0 && index == 1)
            {
                Console.Clear();
                Start = "Напоминание на 07.11.22 по поводу практических работ";
                Massive = new string[] { "описание для книги", "Сделать до 09.11.22" };
            }
            else if (perecl == 1 && index == 0)
            {
                Console.Clear();
                Start = "Напоминание на 08.11.22 по поводу практических работ";
                Massive = new string[] { "описание для третьей" };
            }

            else if (perecl == 2 && index == 0)
            {
                Console.Clear();
                Start = "Напоминание на 08.11.22 по поводу практических работ";
                Massive = new string[] { "описание для четвертой" };
            }
            else if (perecl == 3 && index == 0)
            {
                Console.Clear();
                Start = "Напоминание на 10.11.22 по поводу практических работ";
                Massive = new string[] { "описание для пятой" };
            }
            DisplayOptions();
        }
    }
}
