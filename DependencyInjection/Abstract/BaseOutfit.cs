using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Abstract
{
    public abstract class BaseOutfit : IOutFit
    {
        protected string item;
        public void GetDressed()
        {
            
            Console.WriteLine("{0} looks great on you",item);
        }
    }
}
