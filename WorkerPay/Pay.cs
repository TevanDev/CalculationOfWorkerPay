using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerPay
{
    class Pay
    {
        double pay;
        double tax = 0.14;
        public double tPay(double numH, double pPerH)

        {
            pay = (numH * pPerH) - ((numH * pPerH) * tax);

            return pay;
        }
    }
}
