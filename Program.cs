// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Selecione uma opção");
        Console.WriteLine("1 - Abrir arquivo de texto");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
                Environment.Exit(0);
                break;

            case 1:
                Open();
                break;

            case 2:
                Create();
                break;

            default:
                Console.WriteLine("Opção inválida!");
                Menu();
                break;
        }
    }

    static void Open()
    {

    }

    static void Create()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto (Pressione ESC para sair)");
        Console.WriteLine("------------------------------------------");

        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } 
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Save(text);
    }

    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();

        Menu();
    }
}
