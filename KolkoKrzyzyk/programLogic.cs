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


            tab.generateTable();

            do
            {
                
                tab.showTable();
                tab.putSign(Pola.circle);
                Console.Clear();
                tab.showTable();
                if (tab.checkWin() !=null)
                    break;
                tab.putSign(Pola.cross);
                Console.Clear();

            } while (tab.checkWin()==null);

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
