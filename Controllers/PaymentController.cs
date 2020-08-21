using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.PaymentClass;
namespace Test.Controllers
{
    public class PaymentController : Controller
    {
        string Product = "Physical";
        string Duplicateslip = "Duplicateslip";
        string Paymentformembership = "Paymentformembership";
        string Upgradeemail = "Upgradeemail";
        string Learning = "Learning to ski";
        string Paymentforphysicalproduct = "Paymentforphysicalproduct";
        // GET: Payment
        public ActionResult Index()
        {
            PackagingSip obj = new PackagingSip();
           PaymentService _payment = new PaymentService();
            if (Product== "Physical")
            {
                obj.PackageSerianumber = "34234";
                obj.Packagename = "MobilePhone";
                obj.Packageorderdate = "19-08-2020";
                obj.Packageweight = "250 gm";
                obj.Packagedeliveringdate = "19-08-2020";
                obj.Packageamt = 20000;
                int result = _payment.PackgingSlip(obj);
            }
            if (Duplicateslip == "Duplicateslip")
            {
                obj.PackageSerianumber = "34234";
                obj.Packagename = "MobilePhone";
                obj.Packageorderdate = "19-08-2020";
                obj.Packageweight = "250 gm";
                obj.Packagedeliveringdate = "19-08-2020";
                obj.Packageamt = 20000;
                int result = _payment.DuplicatePackgingSlip(obj);
            }
            if (Paymentformembership == "Paymentformembership")
            {
                bool membership = true;
                int result = _payment.MembershipActivation(membership);
            }
            if (Learning == "Learning")
            {
                string  Learningtype = "Learning to SKi";
                int result = _payment.Videolearning(Learningtype);
            }
            if (Upgradeemail == "Upgradeemail")
            {
                string status = "upgrade";
                string emailaddress = "ram@gmail.com";
                int result = _payment.Memberupgradeemail(emailaddress, status);
            }
            if (Paymentforphysicalproduct == "Paymentforphysicalproduct")
            {
                float Payment = 4444;
                string Agentname = "ram@gmail.com";
                int result = _payment.GenerateCommissionPayment(Payment, Agentname);
            }
            
            return View();
        }
          
    }
}