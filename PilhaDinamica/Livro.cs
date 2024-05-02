using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Livro
    {
        string Titulo;
        Livro Anterior;
        public Livro(string titulo)
        {
            this.Titulo = titulo;
            this.Anterior = null;
        }
        public void SetAnterior(Livro livro)
        {
            Anterior = livro;
        }
        public Livro GetAnterior()
        {
            return Anterior;
        }
        //função que retorna o titulo
        public string GetTitulo()
        {
            return Titulo;
        }
        public override string? ToString()
        {
            return "Titulo do Livro: " + Titulo;
        }
    }
}














