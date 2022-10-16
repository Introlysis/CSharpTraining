using System;

namespace ProgChallenge
{
    class SavingsAcct
    {
        private string _firstname;
        private string _lastname;
        private decimal _interestrate;
        private decimal _balance;
        private int _withdrawalcount;

        public SavingsAcct(string firstname, string lastname, decimal interestrate,  decimal balance) {
            _firstname = firstname;
            _lastname = lastname;
            _interestrate = interestrate;
            _balance = balance;
            _withdrawalcount = 0;
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
            if ((_balance - withdrawal) >= 0) {
                _balance -= withdrawal;
                _withdrawalcount++;
                if (_withdrawalcount > 3) {
                    _balance -= 2.00m;
                }
            }
            else {
                Console.WriteLine($"Insufficient Funds. Current balance is {_balance}");
            }
        }

        public void ApplyInterest() {
            _balance *= (1 + _interestrate);
        }
    }
}
