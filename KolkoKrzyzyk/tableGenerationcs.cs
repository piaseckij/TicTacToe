using System;

namespace KolkoKrzyzyk
{
    enum Pola
    {
        empty,
        circle,
        cross
    }

    class tableGeneration
    {

        dataHandling data;


        Pola[] table = new Pola[9];

        public void generateTable()
        {
            for (int i = 0; i < 9; i++)
            {
                table[i] = Pola.empty;

            }
        }

        public void showTable()
        {
            for (int i = 0; i < 9; i++)
            {
                switch (table[i])
                {
                    case Pola.empty:
                        if (i != 2 && i != 5 && i != 8)
                        {
                            Console.Write("   " + "|");
                        }
                        else if (i == 2 || i == 5 || i == 8)
                        {
                            Console.Write("   ");
                        }

                        break;


                    case Pola.circle:
                        if (i != 2 && i != 5 && i != 8)
                            Console.Write(" o" + " |");
                        else if (i == 2 || i == 5 || i == 8)
                            Console.Write(" o");
                        break;
                    case Pola.cross:
                        if (i != 2 && i != 5 && i != 8)
                            Console.Write(" x" + " |");
                        else if (i == 2 || i == 5 || i == 8)
                            Console.Write(" x");
                        break;
                }

                if (i == 2 || i == 5)
                {
                    Console.WriteLine("\n-----------");
                }

            }
        }

        public void putSign(Pola pola)
        {
            dataHandling data = new dataHandling();

            int x;

            x = data.receivePrepareData(pola);

            if (pola == Pola.cross && x != 200 && table[x] == Pola.empty)
            {
                table[x] = Pola.cross;
            }
            else if (pola == Pola.circle && x != 200 && table[x] == Pola.empty)
            {
                table[x] = Pola.circle;
            }

        }


        //trash 

        //public void putCircle()
        //{
        //    dataHandling data = new dataHandling();

        //    int x, y;

        //    (x, y) = data.receivePrepareData(Pola.circle);

        //    if ((x, y) != (3, 3))
        //    {
        //        table[x, y] = Pola.circle;
        //    }
        //}

        //void checkVertical()
        //{
        //    int circleSum = 0;
        //    int crossSum = 0;

        //    tableGeneration tab = new tableGeneration();

        //    for (int i = 0; i < 3; i++)
        //    {


        //        if (tab.table[i, 0] == Pola.cross)
        //        {
        //            crossSum += 1;
        //        }

        //        else if (tab.table[i, 0] == Pola.circle)
        //        {
        //            circleSum += 2;
        //        }

        //        if (circleSum == 6)
        //        {
        //            Console.WriteLine("Wygrały koła");
        //        }
        //        if (crossSum == 3)
        //        {
        //            Console.WriteLine("Wygrały krzyże");
        //        }

        //        circleSum = 0;
        //        crossSum = 0;
        //    }
        //}
        public int checkWin()
        {

            #region sprawdzenie wygranej poziom
            if (table[0] == table[1] && table[1] == table[2] && table[0] != Pola.empty)
            {
                return 1;
            }

            else if (table[3] == table[4] && table[4] == table[5] && table[3] != Pola.empty)
            {
                return 1;
            }

            else if (table[6] == table[7] && table[7] == table[8] && table[6] != Pola.empty)
            {
                return 1;
            }
            #endregion

            #region sprawdzenie wygranej pion
            else if (table[0] == table[3] && table[3] == table[6] && table[0] != Pola.empty)
            {
                return 1;
            }
            else if (table[1] == table[4] && table[4] == table[7] && table[1] != Pola.empty)
            {
                return 1;
            }
            else if (table[2] == table[5] && table[5] == table[8] && table[2] != Pola.empty)
            {
                return 1;
            }
            #endregion

            #region sprawdzanie wygranej skos
            else if (table[0] == table[4] && table[4] == table[8]&&table[0]!=Pola.empty)
            {
                return 1;
            }
            else if (table[2] == table[4] && table[4] == table[6]&&table[2]!=Pola.empty)
            {
                return 1;
            }
            #endregion

            #region sprawdzanie remisu
            else if (table[0] != Pola.empty && table[1] != Pola.empty && table[2] != Pola.empty && table[3] != Pola.empty
                && table[4] != Pola.empty && table[5] != Pola.empty && table[6] != Pola.empty && table[7] != Pola.empty
                && table[8] != Pola.empty)
            {
                return -1;
            }

            else
                return 0;
            #endregion

        }
    }
}
