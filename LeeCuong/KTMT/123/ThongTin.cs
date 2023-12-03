using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123
{
    public abstract class ThongTin
    {
        private string ho;
        private string ten;

        public ThongTin(string hoValue,string tenValue)
        {
            Ho = hoValue;
            Ten = tenValue;
        }

        public string Ho;
        /*{
            get => default;
            set
            {
            }
        }*/

        public string Ten;
        /*{
            get => default;
            set
            {
            }
        }*/

        public override string ToString()
        {
            return Ho + " " + Ten;
            throw new System.NotImplementedException();
        }

        public abstract decimal Luong();

        public abstract string Position();
    }
}