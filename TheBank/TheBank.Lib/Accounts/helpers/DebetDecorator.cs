using System;
using TheBank.Lib.Interfaces;

namespace TheBank.Lib.Accounts.helpers
{
    public class DebetDecorator : IAccount
    {
        private readonly double _maxDebet;
        private readonly IAccount _wrappedObject;
        private double _debet;

        public DebetDecorator(IAccount wrappedObject, double amount = 2000)
        {
            _debet = 0;
            _maxDebet = amount;
            _wrappedObject = wrappedObject;
        }

        public bool Withdraw(double amount)
        {
            if (_wrappedObject.Balance >= amount)
                return _wrappedObject.Withdraw(amount);
            if (_wrappedObject.Balance + (_maxDebet - _debet) >= amount)
            {
                var tmpBalance = amount - _wrappedObject.Balance;
                _wrappedObject.Withdraw(_wrappedObject.Balance);
                _debet -= tmpBalance;
                return true;
            }
            return false;
        }

        public bool PayIn(double amount)
        {
            if (_debet < 0)
            {
                var tmpAmount = amount - _debet;

                if (tmpAmount > 0)
                {
                    _debet = 0;
                    return _wrappedObject.PayIn(tmpAmount);
                }
                _debet = _debet + amount;
                return true;
            }
            return _wrappedObject.PayIn(amount);
        }

        public double Balance
        {
            get { return _wrappedObject.Balance + _maxDebet + _debet; }
            set { throw new NotImplementedException(); }
        }
    }
}