using System;

namespace MyFirstApp.AbstractClasses
{
    public abstract class GeeksForGeeks : ICloneable
    {
        /*public object Clone()
        {
            throw new NotImplementedException();
        }*/

        // abstract method 'gfg()'
        public abstract void gfg();

        public abstract object Clone();

        public string Test()
        {
            return "we are testing";
        }

        public virtual string VirtualMethod()
        {
            return "we are in VirtualMethod";
        }
    }
}
