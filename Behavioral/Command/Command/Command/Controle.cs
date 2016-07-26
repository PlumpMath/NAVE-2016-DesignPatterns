using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Controle
    {
        private Command[] commands;
        private Command ultimoCommand;

        public Controle(Command abrirCommand, Command fecharCommand)
        {
            this.commands = new Command[2];
            commands[0] = abrirCommand;
            commands[1] = fecharCommand;
        }

        public void abrirPortão()
        {
            commands[0].Execute();
            ultimoCommand = commands[0];
        }

        public void fecharPortão()
        {
            commands[1].Execute();
            ultimoCommand = commands[0];
        }

        public void desfazer()
        {
            ultimoCommand.Undo();
        }
    }
}
