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
       public class Accounts : XPObject
    {
        private string _accountName;

        public string AccountName
        {
            get { return _accountName; }
            set { SetPropertyValue("AccountName", ref _accountName, value); }
        }
        private int _AccNo;

        public int AccountNo
        {
            get { return _AccNo; }
            set { SetPropertyValue("AccountNo", ref _AccNo, value); }

        }

        private Customers customers;
        public Customers Customers { get { return customers; }
            set { SetPropertyValue("Customers", ref customers, value); }
        }
        public Accounts(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
      
    }
}