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

        public Pola? checkWin()
        {

            #region sprawdzenie wygranej poziom
            if (table[0] == table[1] && table[1] == table[2] && table[0] != Pola.empty)
            {
                return table[0];
            }

            else if (table[3] == table[4] && table[4] == table[5] && table[3] != Pola.empty)
            {
                return table[3];
            }

            else if (table[6] == table[7] && table[7] == table[8] && table[6] != Pola.empty)
            {
                
                return table[6];
            }
            #endregion

            #region sprawdzenie wygranej pion
            else if (table[0] == table[3] && table[3] == table[6] && table[0] != Pola.empty)
            {
                
                return table[0];
            }
            else if (table[1] == table[4] && table[4] == table[7] && table[1] != Pola.empty)
            {
                
                return table[1];
            }
            else if (table[2] == table[5] && table[5] == table[8] && table[2] != Pola.empty)
            {
                return table[2];
            }
            #endregion

            #region sprawdzanie wygranej skos
            else if (table[0] == table[4] && table[4] == table[8]&&table[0]!=Pola.empty)
            {
                return table[0];
            }
            else if (table[2] == table[4] && table[4] == table[6]&&table[2]!=Pola.empty)
            {
                return table[2];
            }
            #endregion

            #region sprawdzanie remisu
            else if (table[0] != Pola.empty && table[1] != Pola.empty && table[2] != Pola.empty && table[3] != Pola.empty
                && table[4] != Pola.empty && table[5] != Pola.empty && table[6] != Pola.empty && table[7] != Pola.empty
                && table[8] != Pola.empty)
            {
                
                return Pola.empty;
            }

            return null;
           
            #endregion

        }
    }
}
