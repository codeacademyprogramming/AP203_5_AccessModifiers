using System;
using System.Collections.Generic;
using System.Text;

namespace _15032022
{
    internal class Car
    {
        private int _fuelCapacity;

        public int FuelCapacity
        {
            get => this._fuelCapacity;
            set
            {
                if (value > 29)
                    this._fuelCapacity = value;
            }
        }
    }
}
