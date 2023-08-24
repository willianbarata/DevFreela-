using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommand
    {
        public FinishProjectCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}
