class Program
{
    public static void Main()
    {
        int idade;

        int renda;

        Console.WriteLine("Qual e sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual e sua renda: ");
        renda = Convert.ToInt32(Console.ReadLine());

        if (idade >= 66 && renda < 2000)
        {
            Console.WriteLine("Tem isenção");
        }
        else
        {
            Console.WriteLine("Não tem isenção");
        }
    }
}
