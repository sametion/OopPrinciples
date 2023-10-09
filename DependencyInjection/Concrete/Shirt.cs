using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Shirt : BaseOutfit
    {
        public Shirt()
        {
            item = "shirt";
        }
    }
}
