using System;

namespace KolkoKrzyzyk
{
    class dataHandling
    {
        string input;


        public int receivePrepareData(Pola pola)
        {

            int input = 0;

            Console.WriteLine($"\nPodaj miejsce w którym chcesz ustawić znak {pola} \n");
            bool success = int.TryParse(Console.ReadLine(), out input);



            if (!success || input < 0 || input > 9)
            {
                Console.WriteLine("Błąd we wprowadzeniu (Podaj liczbę od 1-9");
                return 200;
            }


            return input - 1;

        }
    }
}
