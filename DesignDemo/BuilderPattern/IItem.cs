using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 食物条目
    /// </summary>
    public interface IItem
    {
        String Name();
        IPacking Packing();
        Double Price();
    }



    public interface IPacking
    {
        String Packing();
    }
}
