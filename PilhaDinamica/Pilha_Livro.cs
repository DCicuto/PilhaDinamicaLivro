using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro Topo;
        public PilhaLivro()
        {
            Topo = null;
        }
        public void Push(Livro aux)
        {
            if (Vazia())
                Topo = aux;
            else
            {
                aux.SetAnterior(Topo);
                Topo = aux;
            }
        }
        bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }
        public void Print()
        {
            Livro aux = Topo;
            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...\n\n");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetAnterior();
                } while (aux != null);
                Console.WriteLine("\nFim da Impressão");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
                Topo = Topo.GetAnterior();
        }

        public void BuscarLivro(string tituloBuscado)
        {
            // variaveis auxiliares
            Livro livroInterno = Topo;
            bool livroEncontrado = false;

            // verifica se a pilha esta vazia
            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...\n\n");
                Console.ReadKey();
            }
            else
            {
                // se nao estiver vazia, ele vai fazer um do while
                // (enquanto livroInterno for diferente de vazio) para buscar o livro
                do
                {
                    // se o livro for encontrado, a variavel booleana vai receber
                    // true e informar ao usuario
                    if (livroInterno.GetTitulo() == tituloBuscado)
                    {
                        livroEncontrado = true;
                        Console.WriteLine("\nO livro encontrado na pilha!");
                        Console.ReadKey();
                    }

                    // caso nao encontrar, ele vai pegar a posição anterior da pilha e tentar novamente
                    livroInterno = livroInterno.GetAnterior();
                } while (livroInterno != null);

                // se rodar toda a pilha, e nao encontrar nada, ele vai sair do do while e informar ao usuario
                if (!livroEncontrado)
                {
                    Console.WriteLine("\nO livro não foi encontrado na pilha!");
                    Console.ReadKey();
                }
            }
        }
    }
}