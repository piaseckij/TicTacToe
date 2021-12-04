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
                if (tab.checkWin() == 1 || tab.checkWin() == -1)
                    break;
                tab.putSign(Pola.cross);
                Console.Clear();

            } while (tab.checkWin() != 1&&tab.checkWin()!=-1);
            Console.WriteLine(tab.checkWin());

        }

    }

}
