using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndBehavior
{
    public interface IMutableState
    {
        void Set<T>(ItemKey itemKey, PropertyKey property, T value);

        void UnSet(ItemKey itemKey, PropertyKey property);

        void Splice();

        void Invalidate(ItemKey itemKey);

        void Dirty(ItemKey itemKey);

        void Populate();
    }
}
