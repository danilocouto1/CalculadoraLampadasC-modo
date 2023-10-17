class Program
{
    private static void Main(string[] args)
    {
        //Entrada de dados
        Console.WriteLine("Bem vindo a calculadora de lampadas por comodo!");
        Console.WriteLine("Qual comodo deseja iluminar?");
        string comodo = Console.ReadLine();
        Console.WriteLine("Insira a largura do comodo: ");
        decimal larguraComodo = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Insira a comprimento do comodo: ");
        decimal comprimentoComodo = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Insira quantos watts de potencia tem as lampadas que usara: ");
        int wattsLampada = int.Parse(Console.ReadLine());

        //Processamento de dados
        decimal metrosQuadrados = larguraComodo * comprimentoComodo;
        decimal quocienteX = wattsLampada / 18M;
        decimal totalLampadas = metrosQuadrados / quocienteX;
        totalLampadas = Math.Round(totalLampadas);

        //Saida de dados
        Console.WriteLine($"Para iluminar o comodo {comodo} usanda lampadas de {wattsLampada}watts é necessario o total de {totalLampadas} lampadas.");


    }
}