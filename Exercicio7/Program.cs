class Program
{
    public static void Main()
    {
        bool cadastrado = true;
        bool cupomValido = false;
        bool jaUsouCupom = false;

        if (cadastrado == true && cupomValido == true && jaUsouCupom == false)
        {
            Console.WriteLine("Promoção valida");
        }
        else
        {
            Console.WriteLine("Não é valida");
        }
    }
}
