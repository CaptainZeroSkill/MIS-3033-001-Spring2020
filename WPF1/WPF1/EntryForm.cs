using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        /// <summary>
        /// Default/Empty Constructor for the EntryForm Class
        /// </summary>
        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }
        /// <summary>
        /// Overloaded constructor with 3 parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }

        public EntryForm(string address, int zipCode)
        {
            //Even though name is not passed through as a parameter, you still need to define the Name variable
            Name = string.Empty;
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
