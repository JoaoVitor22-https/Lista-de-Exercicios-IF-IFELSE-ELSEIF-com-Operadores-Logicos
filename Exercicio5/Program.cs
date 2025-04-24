class Program
{
    public static void Main()
    {
        int compras;

        Console.WriteLine("Qual é clinte VIP?: ");
        string informacao = Console.ReadLine();

        Console.WriteLine("Quantas compras você fez?: ");
        compras = Convert.ToInt32(Console.ReadLine());

        if ( informacao == "sim" && compras <= 12)
        {
            Console.WriteLine("Tem desconto VIP");
        }
        else
        {
            Console.WriteLine("Não tem desconto");
        }
    }
}
