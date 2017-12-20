using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPad.Forms
{
    class FinanceiroModel
    {
        public string status { get; set; }
        public string color {
            get {
                if (status == "OK") 
                    return "#3ace3a";
                return "#ff392e";
            }
        }
        public string referencia { get; set; }
        public string venc { get; set; }
        public string valor { get; set; }
        public string pag { get; set; }

    }
}
