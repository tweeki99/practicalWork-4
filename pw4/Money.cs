using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw4
{
    class Money
    {
        private int _denomination;
        private int _quantity;

        public Money(int denomination, int quantity)
        {
            _denomination = denomination;
            _quantity = quantity;
        }

        public string GetMoney()
        {
            return _quantity + " купюр номиналом " + _denomination + " тг";
        }

        public bool ItEnough (int price)
        {
            if ( price <= _denomination * _quantity)
            {
                return true;
            }
            return false;
        }

        public int HowManyBuy(int price)
        {
            int allMoney = _denomination * _quantity;
            return allMoney / price;
        }

        public int GetDenomination()
        {
            return _denomination;
        }

        public void SetDenomination(int denomination)
        {
            _denomination = denomination;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public int GetAllMoney()         
        {
            int sum = _quantity * _denomination;
            return sum;
        }
    }
}
