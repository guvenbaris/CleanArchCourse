using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.MediatorPatternDeneme
{
    public abstract class ColleagueBase: MediatorBase
    {
        protected MediatorBase Mediator;


        protected ColleagueBase(MediatorBase mediator)
        {
            this.Mediator = mediator;
        }

        public abstract Task<IResponse> Handle(object request);
    }
}



