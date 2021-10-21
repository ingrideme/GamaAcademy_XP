using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGama_XP
{ /*
    public enum Notas
    {
        NotaCem = 100,
        NotaCinquenta = 50,
        NotaVinte = 20,
        NotaDez = 10,
        NotaCinco = 5
    }
    */
   public abstract class Nota
    {
        public Nota(int valor)
        {
            Valor = valor;
        }

       public int Valor { get; set; }
    }

    class NotaCem : Nota
    {
        public NotaCem() : base(100)
        {

        }
    }

    class NotaCinquenta : Nota
    {
        public NotaCinquenta() : base(50)
        {
            
        }
    }

    class NotaVinte: Nota
    {
        public NotaVinte() : base(20)
        {
        
        }
    }

    class NotaDez : Nota
    {
        public NotaDez() : base(10)
        {

        }
    }

    class NotaCinco : Nota
    {
        public NotaCinco() : base(5)
        {
        
        }
    }

}
