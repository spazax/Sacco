using System;
using System.Linq;
using System.Text;
using System.Threading;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Sacco.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    
    public class LoanType : BaseObject
    {
        //private string _name;
        //private decimal _maximumAmmount;
        //private decimal _interestRate;
        //private int _repaymentPeriod;

        //public string Name
        //{
        //    get { return _name; }
        //    set { SetPropertyValue("Name", ref _name, value); }
        //}

        //public decimal MaximumAmmount
        //{
        //    get { return _maximumAmmount; }
        //    set { SetPropertyValue("MaximumAmmount", ref _maximumAmmount, value); }
        //}

        //public decimal InterestRate
        //{
        //    get { return _interestRate;}
        //    set { SetPropertyValue("InterestRate", ref _interestRate, value); }
        //}

        //public int RepaymentPeriod
        //{
        //    get { return _repaymentPeriod; }
        //    set { SetPropertyValue("RepaymentPeriod", ref _repaymentPeriod, value); }

        //}
        //[Association]
        //public XPCollection<Loan> Loans => GetCollection<Loan>("Loans");
        public LoanType(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
         
        }
        
    }
}