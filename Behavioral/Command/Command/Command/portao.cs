using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Portao
    {
        public const int ABERTO = 0;
        public const int FECHADO = 1;

        private int estado;

        public int getEstado(int estado)
        {
            return estado;
        }

        public void setEstado(int estado)
        {
            this.estado = estado;
        }

        public void abrir()
        {
            this.estado = ABERTO;
        }

        public void fechar()
        {
            this.estado = FECHADO;
        }
    }
}
