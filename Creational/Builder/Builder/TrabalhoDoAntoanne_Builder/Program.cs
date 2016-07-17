using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Diretor4 novoDiretor = new Diretor4();
           
            IConstrutorAbstrato4 ConstrutorAbstrato = null;

            ConstrutorAbstrato = new GordinhoLanches4();
            novoDiretor.Construtor(ConstrutorAbstrato);
            Console.WriteLine("Um novo lanche criado:\n\n{0}\n", ConstrutorAbstrato.Produto.ToString());

            ConstrutorAbstrato = new SaudeSempre4();
            novoDiretor.Construtor(ConstrutorAbstrato);
            Console.WriteLine("Um novo lanche criado:\n\n{0}\n", ConstrutorAbstrato.Produto.ToString());

            ConstrutorAbstrato = new ReiDoCachorro4();
            novoDiretor.Construtor(ConstrutorAbstrato);
            Console.WriteLine("Um novo lanche criado:\n\n{0}\n", ConstrutorAbstrato.Produto.ToString());

            Console.ReadKey();

        }
    }
}
