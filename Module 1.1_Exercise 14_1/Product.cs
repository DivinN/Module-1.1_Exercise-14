using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1._1_Exercise_14_1
{
    public enum TypesProduct
    {
        Food,
        HomeTechnology
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public int CostProduct { get; set; }
        public string ImagePath { get; set; }        
        public TypesProduct TypeProduct { get; set; }
    }

}