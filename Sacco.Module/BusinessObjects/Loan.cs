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
    [DefaultClassOptions][ImageName("BO_Contact")]
   
    public class Loan : XPObject
    {


        private int loanNo;

        public int LoanNo
        {
            get { return loanNo; }
            set { SetPropertyValue("LoanNo", ref loanNo, value); }
        }
    
        private string _loanInfo;

        public string LoanInfo
        {
            get { return _loanInfo; }
            set { SetPropertyValue("LoanInfo", ref _loanInfo, value); }
        }
        private LoanType loanType;
        [Association]
        public LoanType LoanType {
            get { return loanType; }
            set { SetPropertyValue("LoanType", ref loanType, value); }
        }

        public Loan(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
        
    }
}