// See https://aka.ms/new-console-template for more information
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
class Program
{
    struct Produto
    {
        public string Nome;
        public int Id;
        public double Preco;
    }

    static void Main()
    {
        Produto[] prod = new Produto[5];
        int i, cont = 0, aux;
        string? a, resp;
        do
        {
            Console.WriteLine("1 - media");
            Console.WriteLine("2 - contagem regresiva");
            Console.WriteLine("3 - cadastro");
            Console.WriteLine("4 - jogo adivinha");
            Console.WriteLine("5 - fatorial");
            Console.WriteLine("6 - leitura ate o negativo");
            Console.WriteLine("0 - sair");
            a = Console.ReadLine();
            i = int.Parse(a);
            switch (i)
            {
                case 1:
                    Media();
                    break;
                case 2:
                    Contage();
                    break;
                case 3:
                    prod[cont] = Cadastro(prod[cont]);
                    aux = 0;
                    cont++;
                    while (aux <= cont)
                    {
                        Imprime(prod[aux]);
                        aux++;
                    }
                    break;
                case 4:
                    Jogo();
                    break;
                case 5:
                    Console.Write("numero: ");
                    resp = Console.ReadLine();
                    aux = int.Parse(resp);
                    aux = Fatorial(aux);
                    Console.WriteLine(aux + "\n");
                    break;
                case 6:
                    LeituraNegativa();
                    break;
            }
        } while (i != 0);
    }
    static void Media()
    {
        Console.Write("Nota da primeira materia: ");
        string? media1 = Console.ReadLine();
        double nota1 = double.Parse(media1);
        Console.Write("Nota da segunda materia: ");
        string? media2 = Console.ReadLine();
        double nota2 = double.Parse(media2);
        double media = (nota1 + nota2) / 2;
        Console.WriteLine("Sua media de notas he = " + media + "\n");
        return;
    }
    static void Contage()
    {
        Console.Write("Numero: ");
        string? numero = Console.ReadLine();
        int num = int.Parse(numero);
        while (num >= 0)
        {
            Console.WriteLine(num);
            num--;
        }
        Console.WriteLine("\n");
        return;
    }

    static Produto Cadastro(Produto prod)
    {
        Console.Write("nome: ");
        prod.Nome = Console.ReadLine();
        Console.Write("id: ");
        string? a = Console.ReadLine();
        prod.Id = int.Parse(a);
        Console.Write("preco: ");
        a = Console.ReadLine();
        prod.Preco = double.Parse(a);
        return prod;
    }
    static void Imprime(Produto produto)
    {
        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Id);
        Console.WriteLine(produto.Preco);
        return;
    }
    static void Jogo()
    {
        Random ran = new Random();
        int numero = ran.Next(100);
        int cont;
        for (cont = 0; cont < 10; cont++)
        {
            Console.Write("numero: ");
            string a = Console.ReadLine();
            int escolha = int.Parse(a);
            if (escolha == numero)
            {
                Console.WriteLine("Voce ganhou!!!\n");
                return;
            }
            else if (escolha > numero && escolha <= (numero + 10))
            {
                Console.WriteLine("um pouco menos");
            }
            else if (escolha > numero && escolha > (numero + 10))
            {
                Console.WriteLine("esta mto alto");
            }
            else if (escolha < numero && escolha >= (numero - 10))
            {
                Console.WriteLine("um pouco mais");
            }
            else if (escolha < numero && escolha < (numero - 10))
            {
                Console.WriteLine("mto baixo");
            }
        }
        Console.WriteLine("Voce perdeu!!!\n");
        return;
    }
    static int Fatorial(int i)
    {
        int aux, fat = 1;
        for (aux = 1; aux <= i; aux++)
        {
            fat = fat * aux;
        }
        return fat;
    }
    static void LeituraNegativa()
    {
        List<double> vet = new List<double>();

        Console.Write("numero: ");
        string a = Console.ReadLine();
        double num = double.Parse(a);

        while (num >= 0) {
            vet.Add(num);

            Console.Write("numero: ");
            a = Console.ReadLine();
            num = double.Parse(a);
        }

        foreach (var i in vet) {
            Console.WriteLine($"{i}");
        }

        return;
    }
}