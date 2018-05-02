using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndBehavior
{
    public interface IObservableState
    {
        IObservable<int> WhenRevisionChanged { get; }

        IObservable<IItem> WhenItemChanged(ItemKey itemKey);

        IObservable<T> WhenPropertyChanged<T>(ItemKey itemKey, PropertyKey propertyKey);
    }
}
