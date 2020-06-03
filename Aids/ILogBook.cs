using System;
using System.Collections.Generic;
using System.Text;

namespace AgileWorks.Aids
{
    public interface ILogBook
    {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }
}
