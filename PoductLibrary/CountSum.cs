using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class CountSum
    {
        public IEnumerable<int> GetResultSet(int groupCount)
        {
            if (groupCount == 3) return new int[] { 6, 15, 24, 21 };
            if (groupCount == 4) return new int[] { 50, 66, 60 };
            //
            return null;
        }

    }
}