using System;
using System.Linq;

namespace KolkoKrzyzyk
{
    enum Pola
    {
        empty,
        circle,
        cross
    }

    enum axisX
    {
        a,
        b,
        c
    }

    class dataHandling
    {
        string input;

        private bool validateData(string input)
        {

            char[] allowedX = { 'a', 'b', 'c' };

            if (input.Length > 2 || input.Length < 2)
            {
                Console.WriteLine("Błąd argument wejśćiowy zbyt dług/ krótki");
                return false;   
            }



            if (allowedX.Contains(char.ToLower(input[0])))
            {
                return true;
            }

            return false;
        }

        public (int, int) receivePrepareData(Pola pola)
        {

            (int, int) output = (3, 3);

            Console.WriteLine($"\nPodaj miejsce w którym chcesz ustawić znak {pola} \n");
            input = Console.ReadLine();


            if (!validateData(input))
            {
                return (3, 3);
            }


            
            switch (char.ToLower(input[0]))
            {
                case 'a':
                    output = (0, (input[1] - '0') - 1);
                    break;
                case 'b':
                    output = (1, (input[1] - '0') - 1);
                    break;
                case 'c':
                    output = (2, (input[1] - '0') - 1);
                    break;


            }

            return output;

        }
    }

    

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
                Console.Clear();
                tab.showTable();
                tab.putCross();
                Console.Clear();
                tab.showTable();
                tab.putCircle();
                Console.Clear();
                tab.showTable();
                tab.putCross();
            } while (tab.checkWin());




        }



    }

}
