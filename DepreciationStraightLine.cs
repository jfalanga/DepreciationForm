using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationForm
{
    class DepreciationStraightLine
    {
        private DateTime dateAddedToInventory;
        private DateTime dateRemovedFromInventory;
        private decimal endValue;
        private TimeSpan lifetime;
        private decimal startValue;

        public DateTime DateAddedToInventory
        {
            set
            {
                dateAddedToInventory = value;
            }
            get
            {
                return dateAddedToInventory;
                
            }
        }

        public DateTime DateRemovedFromInventory
        {
            get
            {
                return dateRemovedFromInventory;
            }
            set
            {
                dateRemovedFromInventory = value;
            }
        }

        public decimal EndValue
        {
            get
            {
                return endValue;
            }
            set
            {
                endValue = value;
            }
        }

        public decimal StartValue
        {
            set
            {
                startValue = value;
            }
            get
            {
                return startValue;
            }
        }

        public TimeSpan LifeTime
        {
            get
            {
                return lifetime;
            }
            set
            {

            }
        }
        
        
        public decimal SalvageValue
        {
            get
            {
                return StartValue - Calc();
            }
        }
        

        public decimal LifeTimeYears
        {
            get
            {
                decimal days = ((decimal)LifeTime.Days);
                decimal d = Decimal.Divide(days, 365M);
                return d;
            }
            set
            {
                decimal d = Decimal.Multiply(value, 365M);
                int ix = (int)Decimal.Round(d);
                LifeTime = new TimeSpan(ix, 0, 0, 0);
            }
        }
        public string Title
        {
            get;set;
        }

        //A property to show what the the rate of Depreciation is
        //(protected, since it doesn't LOOK like it's supposed to be
        //something a user can simply USE, in a program).
        protected decimal DepricationRate
        {
            get
            {
                decimal ix = EndValue - StartValue;
                decimal d = LifeTimeYears / ix;
                return d;
            }
        }

        public decimal Calc(DateTime timeDate)
        {
            int years = timeDate.Year;
            years = years - DateAddedToInventory.Year;
            decimal moneys = Decimal.Multiply((decimal)years, DepricationRate);
            return moneys;
        }

        public decimal Calc()
        {
            return Calc(DateTime.Now);
        }
    }
}
