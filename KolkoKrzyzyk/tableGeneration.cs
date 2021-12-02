using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void generateTable()
        {
            Pola[,] table = new Pola [3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = Pola.empty;

                }
            }

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    if (table[i, j] == Pola.empty)
                    {
                        Console.Write(" "+"|");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
