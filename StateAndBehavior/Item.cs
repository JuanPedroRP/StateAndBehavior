using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndBehavior
{
    public class Item<TEvent>
        where TEvent : Event
    {
        private readonly ItemKey _key;
        private readonly IStateRepository _stateRepository;

        public Item(ItemKey key, IStateRepository stateRepository)
        {
            _key = key;
            _stateRepository = stateRepository;
        }

        protected void Process(TEvent @event)
        {

        }

        public int MyProperty
        {
            get { return _stateRepository.GetValue<int>(_key, "MyProperty"); }
        }
    }
}
