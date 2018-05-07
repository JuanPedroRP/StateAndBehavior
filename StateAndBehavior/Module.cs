using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndBehavior
{
    public class Module<TEvent>
        where TEvent : Event
    {
        public event EventHandler<TEvent> OnEvent;

        public Module(IStateRepository stateRepository)
        {

        }
    }
}
