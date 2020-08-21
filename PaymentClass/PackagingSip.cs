using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.PaymentClass
{
    public class PackagingSip
    {
        public string Packagename { get; set; }
        public string Packageorderdate { get; set; }
        public string PackageSerianumber { get; set; }
        public string Packageweight { get; set; }
        public string Packagedeliveringdate { get; set; }
        public float Packageamt { get; set; }
    }
}