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
    //[ImageName("BO_Contact")]
   
    public class PaymentMethods : BaseObject
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        private string _description;
        [Size(1000)]
        public string Description
        {
            get { return _description; }
            set { SetPropertyValue("Desription", ref _description, value); }
        }
        public PaymentMethods(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
         
        }
        
    }
}