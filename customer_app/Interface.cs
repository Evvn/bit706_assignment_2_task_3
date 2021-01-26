using System;
using System.Collections.Generic;
using System.Text;

namespace customer_app
{
    public interface IObserver
    {
        void Update();
    }

    public interface ISubject
    {
        void AttachObserver(IObserver obs);
        void NotifyObservers();
    }
}
