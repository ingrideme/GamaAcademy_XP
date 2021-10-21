using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGama_XP
{
    public class Saque
    {
        public DateTime Data { get; private set; }
        public int Valor { get; private set; }
    
        public Saque(int valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }

    }
}
