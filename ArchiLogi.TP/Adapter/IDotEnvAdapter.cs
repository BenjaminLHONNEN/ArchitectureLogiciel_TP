using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiLogi.TP.Adapter
{
    public interface IDotEnvAdapter
    {
        string Get(string property);
    }
}
