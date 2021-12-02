using System;

namespace KolkoKrzyzyk
{
    class tableGeneration
    {
        enum Pola
        {
            empty,
            circle,
            cross
        }

        Pola[,] table = new Pola[3, 3];

        public void generateTable()
        {


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = Pola.empty;

                }
            }
        }

        public void showTable()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (table[i, j] == Pola.empty)
                    {
                        Console.Write("  " + "|");
                    }

                }

                if (i < 2)
                {
                    Console.WriteLine("\n---------");
                }
            }
        }
    }

 

    class application
    {
        private tableGeneration tab;

        void start()
        {
            tab.generateTable();
            tab.showTable();

        }

        

    }

}
