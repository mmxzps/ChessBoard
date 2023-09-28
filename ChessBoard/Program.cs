namespace ChessBoard
{
    //Namn: Mojtaba Mobasheri
    //Klass: NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; //dessa är skriven för att få symbolerna att synas.
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string white = "◻︎"; //skapar en variabel med symbolen som värde.
            string black = "◼︎";
            Console.WriteLine("Hur många rader/kolumner? ");
            string input = Console.ReadLine(); //tar input från användaren
            int antal = int.Parse(input); //omvandlar input till en "int" och lägger den i en variabel vid namnet "antal"

            for (int i = 0; i < antal; i++) //antal rader skrivs ut

            {
                for (int j = 0; j < antal; j++) //antal kolumner skrivs ut

                {

                    if ((i + j) % 2 == 0) //här är en kalkyl som kollar om resultatet av i+j blir jämn ska det skrivas ut svart annars skrivs vit.
                        Console.Write(black);
                    else
                        Console.Write(white);
                }
                Console.WriteLine("");

            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------Nu kan du välja egen design på brädan----------");
            Console.WriteLine("---------------↓↓Välj från exmpels nedan↓↓---------------");
            Console.WriteLine("-- ☺ ☻ ♥ ♦ ♣ ♠ • ○ ◙ ♂ ♀ ♪ ♫ ☼ ► ◄ ↕ ▬ ↨ ↑ ↓ → ← ↔ ▲ ▼ --");
            Console.WriteLine("---------------------------------------------------------");

            Console.Write("Välj symbol nummer1: ");
            string symbol1 = Console.ReadLine();

            Console.Write("Välj symbol nummer2: ");
            string symbol2 = Console.ReadLine();

            Console.WriteLine("Hur många rader/kolumner? ");
            string input2 = Console.ReadLine(); 
            int antal2 = int.Parse(input2);

            for (int i = 0; i < antal2; i++)

            {
                for (int j = 0; j < antal2; j++)

                {

                    if ((i + j) % 2 == 0)
                        Console.Write(symbol1 + " ");
                    else
                        Console.Write(symbol2 + " ");
                }
                Console.WriteLine("");
            }

        }
    }
}