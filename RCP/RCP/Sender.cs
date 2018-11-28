using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP
{
    interface Sender
    {
        void Send(string name, string surname, string position, string department, string card);
    }
}
