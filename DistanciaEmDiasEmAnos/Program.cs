internal class Program
{
    private static void Main(string[] args)
    {

        int firstYear, finalYear, count, days = 0;

        Console.WriteLine("Digite qual o ano inicial:");
        firstYear = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Digite qual o ano final:");
            finalYear = int.Parse(Console.ReadLine());
            if (finalYear < firstYear)
                Console.WriteLine("Número inválido\nDigite um ano maior que o ano inicial");
        } while(finalYear < firstYear);

        for (count = firstYear; count < finalYear + 1; count++)
        {
            if ((count % 4 == 0) && (count % 100 != 0) || (count % 400 == 0))
                days += 366;
            else
                days += 365;
        }

        Console.WriteLine("\nDo início do ano " + firstYear + " até o final do ano "
            + finalYear + " tem " + days + " dias.");
    }
}