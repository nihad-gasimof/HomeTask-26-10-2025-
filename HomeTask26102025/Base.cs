using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTask26102025
{
    public abstract class Base
    {
        protected int Id=0;
        protected string Name { get; set; }
        public int GetId() => Id;

        public abstract void GetInfo();
  public string GetName()
        {
            return Name;
        }
      
    }

}
