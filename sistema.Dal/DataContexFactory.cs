using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Dal
{
    public class DataContexFactory
    {
        static private SistemaDataContext dataContext;
        static public SistemaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new SistemaDataContext();
                return dataContext;
            }
        }
    }
}
