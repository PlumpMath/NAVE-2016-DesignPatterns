using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class AbrirCommand : Command
    {
        private Portao portao;

        public AbrirCommand(Portao portao)
        {
            this.portao = portao;
        }

        public override void Execute()
        {
            portao.abrir();
        }

        public override void Undo()
        {
            portao.fechar();
        }
    }
}
