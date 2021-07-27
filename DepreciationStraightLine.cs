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
        private int lifeTime;
        private decimal startValue;
        private decimal salvageVal;

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

        public int LifeTime
        {
            get
            {
                return lifeTime;
            }
            set
            {
                lifeTime = value;
            }
        }
        
        
        public decimal SalvageValue
        {
            get
            {
                return salvageVal;
            }
            protected set
            {
                salvageVal = value;
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
                decimal d = LifeTime / ix;
                return d;
            }
        }

        public virtual void Calc(DateTime timeDate)
        {
            int years = timeDate.Year;
            years -= DateAddedToInventory.Year;
            decimal moneys = Decimal.Multiply((decimal)years, DepricationRate);
            SalvageValue = StartValue - moneys
                ;
        }

        public virtual void Calc()
        {
            Calc(DateTime.Now);
        }

        public override string ToString()
        {
            string bean = Title;
            bean += ". The sarting value is " + StartValue;
            bean += " and the value at the end of it's Lifetime is " + EndValue;
            bean += "(& that life time is: " + LifeTime + " years).";
            return bean;
        }
    }
}
