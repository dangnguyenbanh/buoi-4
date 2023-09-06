using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class ToaDo
    {
        private string diem;

        public string Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        private float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;
        public float Y
        {
            get { return x; }
            set { y = value; }
        }
        public ToaDo(string diem,float x, float y)
        {
            diem = "0";
            x = 0;
            y = 0;
        }
        public ToaDo()
        { 
        
        }
       
    }
}
