using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_643450065_4
{
    public class sale
    {
        bill bill = new bill();
        coupon coupon = new coupon(); 
        public void newBill()
        {
    
        }
        public bool addCoupontoBill(string couponCode)
        {
            return false;
        }
        public bool addProducttoBill()
        {
            return true;
        }
        public double getBillTotalprice() 
        {
            return 0;
        }
        public double payBill(int customePayment)
        {
            return customePayment;
        }
    }
}

