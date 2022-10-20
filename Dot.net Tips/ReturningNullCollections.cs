using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.net_Tips
{
    public class ReturningNullCollections
    {

        public List<string> returnList()
        {
            return null;
        }

        public List<string> returnListCorrectWay()
        {
            return (List<string>)Enumerable.Empty<string>();
        }


    }
}
