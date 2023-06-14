using InspımoDesignPattern1.DAL;
using InspımoDesignPattern1.Models;

namespace InspımoDesignPattern1.ChainOfResponsibility
{
    public class cashier : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            var context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                customerProcess.EmployeeName = "Ali Yıldız";
                customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar müşteriye ödendi, işlem kapatıldı.";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                customerProcess.EmployeeName = "Ali Yıldız";
                customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar veznedar tarafından ödenemedi, işlem şube müdür yardımcısına yönlendirildi.";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }

}
