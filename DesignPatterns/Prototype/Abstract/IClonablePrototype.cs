using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Abstract
{
    public interface IClonablePrototype<TPrototype>
    {
        TPrototype Clone();
    }
}
