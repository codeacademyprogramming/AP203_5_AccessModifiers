using System;
using System.Collections.Generic;
using System.Text;

namespace _15032022
{
    internal class Student:Human
    {
        public Student(string name,string surname)
        {
            this._name = name;
            this._surname = surname;
        }

        public string Name
        {
            get => this._name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 4)
                    this._name = value;
            }
        }

        public string GetInfo()
        {
            return $"FullName: {this._name} {this._surname}";
        }

    }
}
