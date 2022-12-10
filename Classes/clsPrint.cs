using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_InvHardware
{
    public class clsPrint
    {
        public bool xLeft;
        public bool xRight;

        public clsPrint(bool xIzquerda, bool xDerecha)
        {
            this.xLeft = xIzquerda;
            this.xRight = xDerecha;
        }
    }
}
