using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cars:BaseEntity
    {

        private Companys company;
        private string model;
        private int price;
        private int carYear;
        private string carNumber;
        private string description;
        private string ownerShip;
        private int kilometers;
        private bool isSold;

        public Companys Company { get => company; set => company = value; }
        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public int CarYear { get => carYear; set => carYear = value; }
        public string CarNumber { get => carNumber; set => carNumber = value; }
        public string Description { get => description; set => description = value; }
        public string OwnerShip { get => ownerShip; set => ownerShip = value; }
        public int Kilometers { get => kilometers; set => kilometers = value; }
        public bool IsSold { get => isSold; set => isSold = value; }
    }
}
