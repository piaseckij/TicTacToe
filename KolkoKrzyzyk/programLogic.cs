using System;


namespace KolkoKrzyzyk
{

    class application
    {
        tableGeneration tab;
        dataHandling data;



        public void start()
        {
            tab = new tableGeneration();
            data = new dataHandling();

            Boolean success;

            tab.generateTable();

            do
            {

                tab.showTable();
                do
                {
                    success=tab.putSign(Pola.circle);
                } while (!success);
                
                Console.Clear();
                tab.showTable();
                if (tab.checkWin() != null)
                    break;
                do {
                    success=tab.putSign(Pola.cross);
                }while(!success);
                Console.Clear();

            } while (tab.checkWin() == null);

            if (tab.checkWin() == Pola.empty)
            {
                Console.WriteLine("\nRemis");
            }
            else
            {
                Console.WriteLine($"Wygrał gracz {tab.checkWin()}");
            }

        }

    }

}
