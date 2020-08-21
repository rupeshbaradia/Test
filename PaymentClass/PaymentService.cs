using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.PaymentClass;

namespace Test.PaymentClass
{
    public class PaymentService : IPayment
    {
        private readonly IPayment _repo;
        //public PaymentService(IPayment repo)
        //{
        //    this._repo = repo;
        //}
        public int  PackgingSlip(PackagingSip slip)
        {


            try
            {

                return _repo.PackgingSlip(slip);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int DuplicatePackgingSlip(PackagingSip slip)
        {


            try
            {

                return _repo.DuplicatePackgingSlip(slip);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int MembershipActivation(bool membername)
        {


            try
            {

                return _repo.MembershipActivation(membername);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int Upgrade(Employee obj)
              
        {


            try
            {

                return _repo.Upgrade(obj);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int Memberupgradeemail(string Email, string Status)
        {


            try
            {

                return _repo.Memberupgradeemail(Email, Status);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int Videolearning(string Learningtype)
        {


            try
            {

                return _repo.Videolearning(Learningtype);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        public int GenerateCommissionPayment(float Payment,string agentname)
        {


            try
            {

                return _repo.GenerateCommissionPayment(Payment, agentname);
            }
            catch (Exception ex)
            {
                // Utils.LogBase.LogController.WriteError(ex);
                throw ex;
            }

        }
        

    }
}