using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    public class Warning : IDisplayableComponent
    {
        public string _warning;

        public Warning(string warning)
        {
            _warning = warning;
        }
        public void DisplayComponent()
        {
            Console.Write(_warning);
        }
    }
}
