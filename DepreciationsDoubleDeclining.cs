using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationForm
{
    class DepreciationsDoubleDeclining: DepreciationStraightLine
    {
        public override string ToString()
        {
            return base.ToString() + "- now with double declining depreciation!";
        }
    }
}
