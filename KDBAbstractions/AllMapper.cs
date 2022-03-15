using KDBAbstractions.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDBAbstractions
{
    //this is a class that can be used to map anything
    public class AllMapper : IKModelMapper
    {
        Action<IKDataReader> action;
        public AllMapper(Action<IKDataReader> action)
        {
            this.action = action;
        }
        public void map(IKDataReader kdt)
        {
            this.action(kdt);
        }
    }
}
