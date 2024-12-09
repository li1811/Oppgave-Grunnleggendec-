using System;
namespace oppgave
{
    class Program
    {


        static void Main(string[] args)
        {
            Random rnd=new();
            int tilfeldigTall=rnd.Next(); //generer et tilfeldig tall
            double tilfeldigDesimalTall=rnd.NextDouble(); //generer et tilfeldig desimaltall mellom 0 og 1
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; //lager et array med verditype int
            for (int i = 0; i < array.Length; i++) //vi bruker en for-loop til å skrive hver verdi i vår array til konsollen
            {
                Console.WriteLine(array[i]);
            } 

            string[] array2 = {"en", "to", "tre", "fire", "fem", "seks", "sju", "åtte", "ni", "ti"}; //lager et array med verditype string
            foreach (string i in array2) //vi bruker en foreach-loop for å skrive hver verdi med verditype "string" i array2 til konsollen
            {
                Console.WriteLine(i);
            }

            List<string> vårListe = new List<string>{}; //lager en liste med verditype string
            vårListe.Add("en"); //legger til en verdi i listen
            vårListe.Add("to");
            vårListe.Add("tre");

            foreach (string i in vårListe) //vi bruker samme metode som over får å printe hver verdi i vårListe til konsollen
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(tilfeldigTall);
            Console.WriteLine(TilfeldigTekst(10));
            Console.WriteLine(tilfeldigDesimalTall);
            Console.WriteLine(TilfeldigKarakter());

            
        }


        public static string TilfeldigTekst(int lengde) //generer en tilfeldig tekst med hjelp av metoden TilfeldigKarakter, vi kan selv bestemme lengen på teksten med parameteret lengde
        {
            string tekst="";
            int tekstLengde=lengde;

            for (int i = 0; i < tekstLengde; i++)
            {
                tekst+=TilfeldigKarakter();
            }
            
            return tekst;
        }


        
        public static char TilfeldigKarakter() //generer en tilfeldig alfanumerisk karakter
        {
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int index = rnd.Next(chars.Length);

            return chars[index];
            
        }

        
    }
}