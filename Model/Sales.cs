using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sales:Cars
    {

        private int price;
        private DateTime saleDate;

        public int Price { get => price; set => price = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
    }
}
