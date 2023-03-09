namespace HorasEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());
            int dias = horas / 24;
            Console.WriteLine($"A quantidade de dias é: " + dias);

        }
    }
}