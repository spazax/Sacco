using System;
using System.Linq;
using System.Text;
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
        public class LoanContracts : XPObject
    {
        private DateTime _contractStartDate;

        public DateTime LoanStartDate
        {
            get { return _contractStartDate; }
            set { SetPropertyValue("ContractStartDate", ref _contractStartDate, value); }
        }

        private Customers customers;
        [Association("Customers-LoanContracts")]
        public Customers Customers
        {
            get { return customers; }
            set { SetPropertyValue("Customers", ref customers, value); }
        }
        public LoanContracts(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }
        
    }
}