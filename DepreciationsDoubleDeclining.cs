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

        public override void Calc(DateTime timeDate)
        {
            int years = DateAddedToInventory.Year - timeDate.Year;
            decimal myMoneys = StartValue;
            for (int ix = 1; ix < years; ix++)
            {
                decimal someMoney = myMoneys * DepricationRate * 2;
                myMoneys -= someMoney;
            }
            SalvageValue = myMoneys;
        }
    }
}
