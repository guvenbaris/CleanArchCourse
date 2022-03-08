using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.MediatorPatternDeneme
{
    public abstract class MediatorBase
    {
       public abstract IResponse Send(object request);
    }
}
