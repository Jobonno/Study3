using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study3
{
    public class PropertyManager
    {
        MyProperty[] arr = new MyProperty[10];

        public MyProperty[] Arr
        {
            get
            {
                return arr;
            }

            set
            {
                arr = value;
            }
        }
        public bool AddProperty(MyProperty prop)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == null)
                {
                    arr[i] = prop;
                    return true;
                }
            }
            return false;
        }
        public bool UpdateProperty(MyProperty prop)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null && arr[i].PropNumber == prop.PropNumber)
                {
                    arr[i] = prop;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteProperty(int id)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].PropNumber == id)
                {
                    arr[i] = null;
                    return true;
                }
            }
            return false ;
        }
        public string DisplayAll()
        {
            string msg = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    msg += arr[i].PrintInfo() + "\n";
                }

            }return msg;
        }
        public double Total()
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    sum += arr[i].Price;
                }
            }return sum;
        }
        public double Average()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    count++;
                }
            }return Total() / count;
        }
        public MyProperty Max()
        {
            double max = double.MinValue;
            MyProperty prop = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null && arr[i].Price > max)
                {
                    max = arr[i].Price;
                    prop = arr[i];
                }
            }return prop;
        }
        public MyProperty Min()
        {
            double min = double.MaxValue;
            MyProperty prop = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].Price < min)
                {
                    min = arr[i].Price;
                    prop = arr[i];
                }
            }
            return prop;
        }
    }
}
