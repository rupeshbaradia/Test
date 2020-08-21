using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Skuclass
{
    public class Promotion
    {
        public  Dictionary<int, string> Getpromotiontype = null;
        public  Dictionary<int, string> PromotionAmt = null;
        public  Dictionary<int, string> ActivePromotionData = null;
        public  Dictionary<int, int> ActivePromotionAmt = null;
        public  Dictionary<int, string> Setpromotiontype()
        {
            if (Getpromotiontype == null)
            {
                Getpromotiontype = new Dictionary<int, string>();
                Getpromotiontype.Add(1, "A");
                Getpromotiontype.Add(2, "B");
                Getpromotiontype.Add(2, "C");
                Getpromotiontype.Add(4, "D");



            }
            return Getpromotiontype;
        }
        public  Dictionary<int, string> SetPromotionAmt()
        {
            if (PromotionAmt == null)
            {
                PromotionAmt = new Dictionary<int, string>();
                PromotionAmt.Add(1, "50");
                PromotionAmt.Add(2, "30");
                PromotionAmt.Add(3, "20");
                PromotionAmt.Add(4, "10");



            }
            return PromotionAmt;
        }
        public  Dictionary<int, string> SetActivePromotionData()
        {
            if (ActivePromotionData == null)
            {
                ActivePromotionData = new Dictionary<int, string>();
                ActivePromotionData.Add(1, "3 of A's");
                ActivePromotionData.Add(2, "2 of B's");
                ActivePromotionData.Add(3, "C & D");
                



            }
            return ActivePromotionData;
        }
        public  Dictionary<int, int> SetActivePromotionAmt()
        {
            if (PromotionAmt == null)
            {
                ActivePromotionAmt = new Dictionary<int, int>();
                ActivePromotionAmt.Add(1, 130);
                ActivePromotionAmt.Add(2, 45);
                ActivePromotionAmt.Add(3, 30);




            }
            return ActivePromotionAmt;
        }
    }
     
}