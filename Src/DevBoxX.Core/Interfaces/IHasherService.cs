using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBoxX.Core.Interfaces
{
    public interface IHasherService
    {
        string Hash(string message);

    }
}
