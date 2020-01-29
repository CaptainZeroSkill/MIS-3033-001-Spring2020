﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public EntryForm()
        {
           
        }

        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public override string ToString()
        {
            return $"{this.Name} has an address of {this.Address} {this.ZipCode}";
        }
    }
}
