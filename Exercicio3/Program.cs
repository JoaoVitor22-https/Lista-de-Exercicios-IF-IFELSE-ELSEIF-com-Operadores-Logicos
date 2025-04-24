class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Qual e seu usuario?: ");
        string informacao = Console.ReadLine();

        if (informacao == "admin" || informacao == "supervisor")
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}