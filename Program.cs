using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

       
            
                Console.WriteLine();
            Console.WriteLine("digite produto add estoque");
            int qte = int.Parse(Console.ReadLine());
             p.AdicionarProdutos(qte);
            
            Console.WriteLine("Dados do produto: " + p);
           
             
             Console.WriteLine("digite produto remove estoque");
              qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); 
            Console.WriteLine("Dados do produto: " + p);
            
            
        }
    }
}
