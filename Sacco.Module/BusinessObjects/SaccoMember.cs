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
    [DefaultClassOptions]  [ImageName("BO_Contact")]
   
    public class SaccoMember :XPObject
    {
        private int _membershipNo;
        private decimal _shares;
        private decimal _RegisrationFee;

        public decimal RegistrationFee
        {
            get { return _RegisrationFee; }
            set { SetPropertyValue("RegisrationFee", ref _RegisrationFee, value); }
        }

        public decimal Shares
        {
            get { return _shares; }
            
        }

        private decimal _ShareDeposits;

        public decimal ShareDeposits
        {
            get { return _ShareDeposits; }
            set { SetPropertyValue("ShareDeposits", ref _ShareDeposits, value); }
        }

        public int MembershipNo
        {
            get { return _membershipNo; }
            set { SetPropertyValue("MembershipNo", ref _membershipNo, value); }
        }
        public SaccoMember(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
       
        }
      
    }
}