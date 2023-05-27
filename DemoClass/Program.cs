using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //XeHoi xe1 = new XeHoi("Ford", 1);
            //XeHoi xe2 = new XeHoi();
            //xe1.setNhaSanXuat("Ford");    
            //Console.WriteLine(xe1.getNhaSanXuat());

            SinhVien sv1 = new SinhVien();


            sv1.nhap();
            sv1.xuat();


            Console.ReadKey();

        }


    }


}
