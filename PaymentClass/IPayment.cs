using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PaymentClass
{
    public interface IPayment
    {
       int  PackgingSlip(PackagingSip slip);
        int DuplicatePackgingSlip(PackagingSip slip);
        int MembershipActivation(bool MemberName);
        int Memberupgradeemail(string Email,string Status);
        int Upgrade(Employee obj);
        int Videolearning(string Learningtype);
        int GenerateCommissionPayment(float Payment,string Agentname);
    }
}
