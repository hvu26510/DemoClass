using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class SinhVien
    {
        private string _name;
        private double _diem;

        public string getName()
        {
            return this._name;
        }
        public double getDiem()
        {
            return this._diem;
        }
        public void setDiem(double diem)
        {
            if(diem <0 || diem > 10)
            {
                Console.WriteLine("Diem khong dung");
            }
            else
            {
                this._diem = diem;
            }
            
        }
        public void setName(string name)
        {
            this._name = name;
        }
        public SinhVien(string name, double diem)
        {
            _name = name;
            _diem = diem;
        }

        public SinhVien()
        {
        }


        public void nhap()
        {
            Console.WriteLine("Nhap ten sv:");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap diem sv:");
            double diem = double.Parse(Console.ReadLine());

            this.setName(name);
            this.setDiem(diem);
        }

        public void xuat()
        {
            Console.WriteLine("Ten sv: " + this.getName());
            Console.WriteLine("Diem: " + this.getDiem());
        }

        public string XepLoaiHocLuc()
        {
            if(this._diem >= 8)
            {
                return "gioi";
            }else if(this._diem >= 6.5)
            {
                return "Kha";
            } else if (this._diem >= 5)
            {
                return "TB";
            }
            else
            {
                return "Yeu";
            }
        }
    }
}
