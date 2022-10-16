using System;

namespace ProgChallenge
{
    class CheckingAcct
    {
        private string _firstname;
        private string _lastname;
        private decimal _balance;

        public CheckingAcct(string firstname, string lastname, decimal balance) {
            _firstname = firstname;
            _lastname = lastname;
            _balance = balance;
        }

        public decimal Balance {
            get {
                return _balance;
            }
            set {
                _balance = value;
            }
        }

        public string AccountOwner {
            get {
                return $"{_firstname} {_lastname}";
            }
        }

        public void Deposit(decimal deposit) {
            _balance += deposit;
        }

        public void Withdraw(decimal withdrawal) {
            _balance -= withdrawal;
            //overdraft fee
            if (_balance < 0) {
                _balance -= 35m;
            }
        }
    }
}
