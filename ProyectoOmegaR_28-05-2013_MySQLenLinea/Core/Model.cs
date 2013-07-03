using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Model
    {
        string mensaje;
        public Model()
        {  }
        public void SetMensaje(string M)
        {
            mensaje = M;
        }
        public string getMensaje()
        {
            return mensaje;
        }
    }
}
