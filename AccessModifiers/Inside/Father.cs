using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Outside;


namespace Inside
{
    public class Father : GrandFather
    {
        protected int ProtectedNumber=30;

        internal int InternalNumber=40;

        public int ProtectedInternalOut{get{return ProtectedOutsideInternalNumber;}}
    }
}