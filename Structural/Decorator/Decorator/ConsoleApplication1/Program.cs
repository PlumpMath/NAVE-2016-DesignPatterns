using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    using System;
    using System.Text;


    namespace xXx_exemplodecorator_xXx
    {
        class Program
        {
            static void Main(string[] args)
            {
                Pessoa pessoa;
                pessoa = new Pessoa();


                Console.WriteLine("usando Pessoa:");
                Console.WriteLine(pessoa.Andar());


                Console.WriteLine();


                PessoaRapida pessoaRapida;
                pessoaRapida = new PessoaRapida(pessoa);


                Console.WriteLine("usando PessoaRapida:");
                Console.WriteLine(pessoaRapida.Andar());
                Console.WriteLine(pessoaRapida.Correr());


                Console.WriteLine();


                PessoaLenta pessoaLenta;
                pessoaLenta = new PessoaLenta(pessoa);


                Console.WriteLine("usando PessoaLenta:");
                Console.WriteLine(pessoaLenta.Andar());


                Console.ReadKey();
            }
        }


        //IComponent
        interface IPessoa
        {
            //Operation
            String Andar();
        }

        //Component
        sealed class Pessoa : IPessoa
        {
            //Operation
            public String Andar()
            {
                return "andei";
            }
        }


        //Decorator
        class PessoaRapida : IPessoa
        {
            //Component : IComponent
            IPessoa p;


            public PessoaRapida(IPessoa p)
            {
                this.p = p;
            }


            //Operation
            public String Andar()
            {
                return new StringBuilder(p.Andar())
                    .Append(" ")
                    .Append("rápido")
                    .ToString();
            }


            //AddedBehavior
            public String Correr()
            {
                return "corri";
            }
        }


        //Decorator
        class PessoaLenta : IPessoa
        {
            //Component : IComponent
            IPessoa p;


            public PessoaLenta(IPessoa p)
            {
                this.p = p;
            }


            //Operation
            public String Andar()
            {
                return new StringBuilder(p.Andar())
                    .Append(" ")
                    .Append("devagar")
                    .ToString();
            }
        }
    }

