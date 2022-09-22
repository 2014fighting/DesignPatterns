using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// 房屋中介
    /// </summary>
    public interface IHouseAgent
    {

        /// <summary>
        /// 用户联系沟通购房需求,并匹配房源
        /// </summary>
        public void ContactUser(User user);


        /// <summary>
        /// 房屋所有者提供房源
        /// </summary>
        /// <param name="user"></param>
        public void ContactOwner(House house);
    }

    /// <summary>
    /// 房屋中介实现类
    /// </summary>
    public class HouseAgent : IHouseAgent
    {
        private List<House> _house = new List<House>();
        public void ContactUser(User user)
        {
           var house= _house.FirstOrDefault(i => i.Condition == user.Requirement);

            if (house != null)
            {
                Console.WriteLine($"匹配成功！房屋编号是：{house.IdNumber}");
            }
            else
            {
                Console.WriteLine($"暂时没有符合的房源");
            }
             
        }

        public void ContactOwner(House house)
        {
            _house.Add(house);
        }
  
    }

    public class House
    {
        public int IdNumber { get; set; }
        public string? Condition { get; set; }
    }

    public class User
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// 购房需求
        /// </summary>
        public string? Requirement { get; set; }
    }

}
