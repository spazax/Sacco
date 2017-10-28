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
    
    public class Staffs : XPObject
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;

        public string FirstName
        {
            get { return _firstName; }
            set { SetPropertyValue("FirstName", ref _firstName, value); }
        }

         private string LastName
        {
            get { return _lastName;}
            set { SetPropertyValue("LastName", ref _lastName, value); }
        }

        private string MiddleName
        {
            get { return _middleName; }
            set { SetPropertyValue("MiddleName", ref _middleName, value); }
        }
        public Staffs(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
       
    }
}