using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 定义一个个体和组合通用的抽象
    /// </summary>
    public abstract class OrganizationComponent
    {
        private string name;

        public OrganizationComponent(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public abstract void Add(OrganizationComponent organization);

        public abstract OrganizationComponent? GetChild(string orgName);

        public abstract int GetStaffCount();
    }
}
