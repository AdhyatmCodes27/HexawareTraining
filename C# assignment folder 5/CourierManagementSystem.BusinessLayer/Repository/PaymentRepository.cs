using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    public class PaymentRepository: IPaymentRepository
    {
        public PaymentRepository() { }

        //Parameterized constructor
        Payment payment = new Payment();

        public PaymentRepository(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            payment.PaymentID = paymentID;
            payment.CourierID = courierID;
            payment.Amount = amount;
            payment.PaymentDate = paymentDate;
           

        }

        public override string ToString()
        {
            return $"Payment {{ paymentID={payment.PaymentID}, courierID='{payment.CourierID}', amount='{payment.Amount}', " +
                   $"paymentDate='{payment.PaymentDate}' }}";

        }
        public void DisplayPaymentInfo()
        {
            Console.WriteLine($"{payment.PaymentID}, {payment.CourierID},{payment.Amount},{payment.PaymentDate}");
        }

       
    }
}

