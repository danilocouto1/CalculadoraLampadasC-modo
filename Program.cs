class Program
{
    private static void Main(string[] args)
    {
        //Entrada de dados
        Console.WriteLine("Bem vindo a calculadora de lampadas por comodo!");
        Console.WriteLine("Qual comodo deseja iluminar?");
        string comodo = Console.ReadLine();
        Console.WriteLine("Insira a largura do comodo: ");
        int larguraComodo = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a comprimento do comodo: ");
        int comprimentoComodo = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira quantos watts de potencia tem as lampadas que usara: ");
        int wattsLampada = int.Parse(Console.ReadLine());

        //Processamento de dados
        int metrosQuadrados = larguraComodo * comprimentoComodo;
        int quocienteX = wattsLampada / 18;
        int totalLampadas = metrosQuadrados / quocienteX;

        

    }
}