using System;
using System.Collections.Generic;
using System.Text;

namespace _15032022
{
    internal class Human
    {
        protected string _name;
        protected string _surname;


        public string Name
        {
            get => this._name;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length>2)
                    this._name = value;
            }
        }

    }


}
