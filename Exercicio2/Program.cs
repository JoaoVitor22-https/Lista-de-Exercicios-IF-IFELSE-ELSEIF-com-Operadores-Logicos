class Program
{
    public static void Main()
    {
        int numero = 20;

        Console.WriteLine("Você tem CNH?: ");
        string informacao = Console.ReadLine();

        if (numero >=18 && informacao == "sim")
        {
            Console.WriteLine("Pode dirigir");
        }
        else
        {
            Console.WriteLine("Não pode dirigir");
        }
    }
}