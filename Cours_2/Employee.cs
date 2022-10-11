using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_2
{
    public class Employee
    {
        public string Name { get; }
        protected decimal _basepay;
        public Employee(string name, decimal basepay)
        {
            Name = name;
            _basepay = basepay;
        }

        public virtual decimal CalculatorPay()
        {
            return _basepay;
        }
    }

    public class SalesEmployee: Employee
    {
        private decimal _salesbonus;
        public SalesEmployee(string name, decimal basepay, decimal salesbonus) : base(name, basepay)
        {
            _salesbonus = salesbonus;
        }
        public override decimal CalculatorPay()
        {
            return _basepay + _salesbonus;
        }
    }
}
