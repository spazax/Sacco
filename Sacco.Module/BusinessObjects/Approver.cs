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
   
    public class Approver : XPObject
    {
        private string _approver;

        public string Aprover
        {
            get { return _approver; }
            set { SetPropertyValue("Approver", ref _approver, value); }
        }
        public Approver(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
        
    }
}