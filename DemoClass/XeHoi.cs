using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class XeHoi
    {
        private string NhaSanXuat;
        private int idCar;

        public string getNhaSanXuat()
        {
            return this.NhaSanXuat;
        }
        public void setNhaSanXuat(string nxs)
        {
            this.NhaSanXuat = nxs;
        }
        public XeHoi(string nhaSanXuat, int idCar)
        {
            NhaSanXuat = nhaSanXuat;
            this.idCar = idCar;
        }
        public XeHoi()
        {
        }
    }
}
