using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Lab1
{
    class CustomerList
    {
        public string first { get; set; }
        public string last { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public CustomerList(string first, string last, string address, string city, string state, string zip, string phone, string email)
        {
            this.first = first;
            this.last = last;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
        public CustomerList()
        {
            this.first = null;
            this.last = null;
            this.city = null;
            this.state = null;
            this.zip = null;
            this.phone = null;
            this.email = null;
        }
    }
}