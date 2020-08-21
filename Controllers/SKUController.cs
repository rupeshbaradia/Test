using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Skuclass;
namespace Test.Controllers
{
    public class SKUController : Controller
    {
        // GET: SKU
        public ActionResult Index()
        {
            Promotion obj = new Promotion();
            string Promotiondata = "";
            int Promotionamt;
            int Totalordervalue = 0; ;
            string Senario = "";
            int itemcost = 0;
            int itemcostsku1sku2 = 0;
            int totalitemcostsku = 0;
            int totalitemcostsku1sku2 = 0;
            for (int i=0;i<3;i++)
            {
                Promotiondata = obj.ActivePromotionData[i];
                Promotionamt =  obj.ActivePromotionAmt[i];
                if(Senario== "A")
                {
                    itemcost = 50;
                    totalitemcostsku += itemcost;
                }
                if (Senario == "B")
                {
                    itemcost = 130+ 2*50;
                    totalitemcostsku += itemcost;
                }
                if (Senario == "C")
                {
                    itemcost = 130 ;
                    totalitemcostsku += itemcost;
                }
                

                if (i <2)
                {
                    totalitemcostsku1sku2 = 50+30;
                    itemcostsku1sku2 += totalitemcostsku1sku2+20+20+30;
                }
                if (i == 2)
                {
                    Totalordervalue = totalitemcostsku + itemcostsku1sku2;
                }
            }
          
            return View();
        }
    }
}