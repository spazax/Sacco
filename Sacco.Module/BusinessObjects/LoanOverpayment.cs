﻿using System;
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
   
    public class LoanOverpayment : BaseObject
    {

        private Loan _loan;
        [Association("Loan-LoanOverpayment")]
        public Loan loan
        {
            get { return _loan; }
            set { SetPropertyValue("Loan", ref _loan, value); }
        }
        public LoanOverpayment(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
     
    }
}