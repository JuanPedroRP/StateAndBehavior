using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndBehavior
{
    public interface IStateRepository : IMutableState
    {
        T GetValue<T>(PropertyKey key);
    }
}
