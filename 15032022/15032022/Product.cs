using System;
using System.Collections.Generic;
using System.Text;

namespace _15032022
{
    internal class Product
    {
        //public Product(double price)
        //{
        //    if(price>=0)
        //        this.Price = price;
        //}

        public Product(double discountedPrice,double tax)
        {
            this.DiscountedPrice = discountedPrice;
            this.Tax = tax;
        }

        public readonly double Tax;

        private double _price;
        private string _name;
        private byte _age;
        private double _discountPercent;

        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (value >= 0)
                    this._price = value;
            }
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length>2)
                    this._name = value;
            }
        }

        public double DiscountPercent {
            get => this._discountPercent;
            set
            {
                if (value >= 0)
                {
                    this._discountPercent = value;
                    this.DiscountedPrice = this._price * (100 - value) / 100;
                }

            }
        }

        public byte Age
        {
            get => this._age;
            set
            {
                if (value >= 0 && value<100)
                    this._age = value;
            }
        }

        public double DiscountedPrice { get; private set; }

        public double PriceGetter()
        {
            return this._price;
        }

        public void PriceSetter(double val)
        {
            if(val>=0)
                this._price = val;
        }

        public string GetInfo()
        {
            return $"Price: {this._price}";
        }
    }
}
