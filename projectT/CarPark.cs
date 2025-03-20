using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectT
{
    public class CarPark
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        public string LicNumber {  get; set; }
        public DateTime StartParkTime { get; set; }

        public DateTime EndParkTime { get; set; }
        /// <summary>
        /// 停放位置
        /// </summary>
        public string ParkLocal {  get; set; }


    }
}
