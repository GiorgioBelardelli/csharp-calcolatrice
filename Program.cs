using static csharp_calcolatrice.Calcolatrice;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "esci")
            {
                Console.WriteLine("Scegli un'opzione");

                Console.WriteLine("1. Somma due numeri interi");
                Console.WriteLine("2. Somma di due numeri decimali");
                Console.WriteLine("3. Differenza di due numeri interi");
                Console.WriteLine("4. Differenza tra due numeri decimali");
                Console.WriteLine("5. Moltiplicazione due numeri interi");
                Console.WriteLine("6. Moltiplicazione due numeri decimali");
                Console.WriteLine("7. Valore assoluto di un numero intero");
                Console.WriteLine("8. Valore assoluto di un numero decimali");
                Console.WriteLine("9. Controllo del minimo tra due numeri interi");
                Console.WriteLine("10. Controllo del minimo tra due numeri decimali");
                Console.WriteLine("11. Controllo del massimo tra due numeri interi");
                Console.WriteLine("12. Controllo del massimo tra due numeri decimali");
                Console.WriteLine("13. Potenza di un numero tramite inserimento di base ed esponente");

                input = Console.ReadLine();

                if (input == "1" || input == "2")
                {
                    Calcolatrice.CalcolaSomma();
                }
                if (input == "3" || input == "4")
                {
                    Calcolatrice.CalcolaDifferenza();
                }
                if (input == "5" || input == "6")
                {
                    Calcolatrice.CalcolaProdotto();
                }
                if (input == "7" || input == "8")
                {
                    Calcolatrice.CalcolaValoreAssoluto();
                }
                if (input == "9" || input == "10")
                {
                    Calcolatrice.RitornaMinimo();
                }
                if (input == "11" || input == "12")
                {
                    Calcolatrice.RitornaMassimo();
                }
                if (input == "13")
                {
                    Calcolatrice.CalcolaPotenza();
                }
            }
        }
    }
}
