using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 汽车4s店
    /// </summary>
    public class CarShop
    {
        public Car Construct(Builder builder)
        {
            return builder.BuildCar();
        }
    }

    /// <summary>
    /// 建造者（模拟装机过程）,也可通过接口实现
    /// CarShop不关心具体组装的细节，所以将具体的组装细节方法标记为protected
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 组装发动机
        /// </summary>
        protected abstract void BuildEngine();

        /// <summary>
        /// 组装变速箱
        /// </summary>
        protected abstract void BuildGearbox();

        /// <summary>
        /// 组装地盘
        /// </summary>
        protected abstract void BuildTerritory();

        /// <summary>
        /// 由具体的组装类决定组装顺序
        /// </summary>
        /// <returns></returns>
        public abstract Car BuildCar();
    }


    public class BydBulider : Builder
    {
        Car byd = new Car() { Band = "比亚迪" };
 
        protected override void BuildEngine()
        {
            byd.AssemblePart("dmi发动机");
        }

        protected override void BuildGearbox()
        {
            byd.AssemblePart("DCT湿式双离合变速箱");
        }

        protected override void BuildTerritory()
        {
            byd.AssemblePart("四连杆地盘");
        }

        public override Car BuildCar()
        {
            BuildEngine();
            BuildGearbox();
            BuildTerritory();
            return byd;
        }
    }

    public class GreatWallBulider : Builder
    {
        Car gw = new Car() { Band = "长城汽车" };

        protected override void BuildEngine()
        {
            gw.AssemblePart("xx发动机");
        }

        protected override void BuildGearbox()
        {
            gw.AssemblePart("xx变速箱");
        }

        protected override void BuildTerritory()
        {
            gw.AssemblePart("xx地盘");
        }

        public override Car BuildCar()
        {
            BuildEngine();
            BuildGearbox();
            BuildTerritory();
            return gw;
        }
    }

    public class Car
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string? Band { get; set; }

        /// <summary>
        /// 汽车组装
        /// </summary>
        private List<string> assemblyParts = new List<string>();

        /// <summary>
        /// 组装部件
        /// </summary>
        /// <param name="partName">部件名称</param>
        public void AssemblePart(string partName)
        {
            this.assemblyParts.Add(partName);
        }

        public void ShowSteps()
        {
            Console.WriteLine("开始组装『{0}』汽车:", Band);
            foreach (var part in assemblyParts)
            {
                Console.WriteLine(string.Format("组装『{0}』;", part));
            }

            Console.WriteLine("组装『{0}』汽车完毕！", Band);
        }
    }
}
