using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sales:Cars
    {

        private int saleprice;
        private DateTime saleDate;

        public int SalePrice { get => saleprice; set => saleprice = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
    }
}
