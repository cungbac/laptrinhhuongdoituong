using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTruong
{
    public class Singleton
    {
        private static Singleton _instance = null;
        public string Name { get; set; }
        private Singleton()
        {
            Name = "ABC";
        }
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
