using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 行政部门
    /// </summary>
    public class AdminDepartment : OrganizationComponent
    {
        public AdminDepartment(string name) : base(name)
        {
        }

        public override void Add(OrganizationComponent organization)
        {
            throw new Exception(this.GetName() + "已经是最基本部门，无法增加下属部门");
        }

        public override OrganizationComponent? GetChild(string orgName)
        {
            return GetName().Equals(orgName) ? this : null;
        }


        public override int GetStaffCount()
        {
            return 50;
        }
    }
}
