using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestInfo
{
    public class Test
    {
        private string data;

        public Test()
        { }

        public Test(string data)
        {
            this.data = data;
        }

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public override string ToString()
        {
            return this.data;

        }
    }
}
