using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailReader
{
    class SubjectClass
    {
        public event EventHandler SomthingHappened;

        public void DoSomething()
        {
            EventHandler handler = SomthingHappened;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }

        }





    }
}
