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
   
    public class LoanGuaranter : XPObject
    {
        //////private Loan _loan;

        //////[Association("Loan-LoanGuaranter")]
        //////public Loan Loan
        //////{
        //////    get { return _loan; }
        //////    set { SetPropertyValue("Loan", ref _loan, value); }
        //////}

        //////private SaccoMember _saccoMember;
        //////[Association("SaccoMember-LoanGuaranter")]
        //////public SaccoMember SaccoMember
        //////{
        //////    get { return _saccoMember; }
        //////    set { SetPropertyValue("SaccoMember", ref _saccoMember, value); }
        //////}

        public LoanGuaranter(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
      
    }
}