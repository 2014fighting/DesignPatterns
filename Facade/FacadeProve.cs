using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 外观模式类
    /// </summary>
    public class FacadeProve
    {
        private SubFlow1 subFlow1;
        private SubFlow2 subFlow2;
        private SubFlow3 subFlow3;
        public FacadeProve()
        {
            subFlow1 = new SubFlow1();
            subFlow2 = new SubFlow2();
            subFlow3 = new SubFlow3();
        }

        //提供一个证明方法即可
        public bool Prove()
        {
            return subFlow1.IsOk() && subFlow2.IsTrue() && subFlow3.IsGoodMan();
        }
    }

    public class SubFlow1
    {
       public bool IsOk() => true;
    }

    public class SubFlow2
    {
        public bool IsTrue() => true;
    }

    public class SubFlow3
    {
        public bool IsGoodMan() => true;
    }

}
