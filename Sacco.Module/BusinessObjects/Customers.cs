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
      public class Customers :XPObject
    {
        private string _firstname;
        private string _lastname;
        private string _middlename;
        [PersistentAlias(@"[FirstName] +'  '+ [MiddleName]+'  '+[LastName]")]

        public string FullName
        {
            get { return (string)(EvaluateAlias("FullName")); }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { SetPropertyValue("FirstName", ref _firstname, value); }
        }

        public string LastName
        {

            get { return _lastname; }

            set { SetPropertyValue("LastName", ref _lastname, value); }
        }

        public string MiddleName
        {
            get { return _middlename; }
            set { SetPropertyValue("MiddleName", ref _middlename, value); }
        }

        private DateTime _BirthDate;

        public DateTime BirthDate
        {
            get { return _BirthDate;}
            set { SetPropertyValue("BirthDate", ref _BirthDate, value); }
        }

        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] Photo { get; set; }
        [Association("Customers-Address")]
        public XPCollection<Address> Address
        {
            get
            {
                return GetCollection<Address>("Address");
            }
        }

        [Association("Customers-LoanContracts")]
        public XPCollection<LoanContracts> LoanContracts
        {
            get
            {
                return GetCollection<LoanContracts>("LoanContracts");
            }
        }
        public Customers(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
         
        }
        
    }
}