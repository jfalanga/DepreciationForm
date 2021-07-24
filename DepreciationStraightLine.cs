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
        
        /*
        public decimal SalvageValue
        {

        }
        */

        public string Title
        {
            get;set;
        }


    }
}
