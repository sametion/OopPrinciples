using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Abstract;

namespace DependencyInjection.Concrete
{
    public class Somebody
    {
        IOutFit _outFit;
        public Somebody(IOutFit outFit)
        {
            _outFit = outFit;
        }

        public void Display()
        {
            _outFit.GetDressed();

        }

    }
}
