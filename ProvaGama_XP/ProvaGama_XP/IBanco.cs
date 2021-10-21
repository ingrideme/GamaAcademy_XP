using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGama_XP
{
    public interface IBanco
    {
        public List<Notas> Sacar(int valordoSaque);
    }

}
