using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeClient
    {
        /// <summary>
        /// 开始构建组织，或者各节点
        /// </summary>
        /// <returns></returns>
        public OrganizationComponent ConstructOrganization()
        {
            //构建总部
            OrganizationComposite head = new OrganizationComposite("总公司");
            AdminDepartment headAdmin = new AdminDepartment("总公司行政部");
            ItDepartment headIt = new ItDepartment("总公司It部");
            head.Add(headAdmin);
            head.Add(headIt);

            //构建分公司
            OrganizationComposite branch1 = new OrganizationComposite("天津分公司");
            AdminDepartment branch1Admin = new AdminDepartment("天津分公司行政部");
            ItDepartment branch1It = new ItDepartment("天津分公司It部");
            branch1.Add(branch1Admin);
            branch1.Add(branch1It);

            //将分公司加入到head中
            head.Add(branch1);

            return head;
        }
    }
}
