using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 组合类
    /// </summary>
    public class OrganizationComposite : OrganizationComponent
    {

        private List<OrganizationComponent> organizations = new List<OrganizationComponent>();

        public OrganizationComposite(string name) : base(name)
        {
        }

        public override void Add(OrganizationComponent organization)
        {
            organizations.Add(organization);
        }

        public override OrganizationComponent? GetChild(string orgName)
        {
            return organizations.FirstOrDefault(i => i.GetChild(orgName) != null);
        }

        public override int GetStaffCount()
        {
            return organizations.Sum(i => i.GetStaffCount());
        }
    }
}
