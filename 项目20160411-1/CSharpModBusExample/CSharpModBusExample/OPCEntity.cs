using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;

namespace CSharpModBusExample
{
    public class OPCEntity
    {
        public OPCGroup Group;
        public OPCItem[] Item;
        public int Count;

        public OPCEntity(OPCGroup group,OPCItem[] item,int count)
        {
            Group = group;
            Item = item;
            Count = count;
        }

        public OPCEntity()
        { }
    }
}
