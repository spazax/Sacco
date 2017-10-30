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
   
    public class Address : XPObject
    {
        private string _addressname;

        public string AddressName
        {
            get { return _addressname; }
            set { SetPropertyValue("AddressName", ref _addressname, value); }
        }

        private Customers customers;
        [Association("Customers-Address")]
        public Customers Customers
        {
            get { return customers; }
            set { SetPropertyValue("Customers", ref customers, value); }
        }
        public Address(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
      
    }
}