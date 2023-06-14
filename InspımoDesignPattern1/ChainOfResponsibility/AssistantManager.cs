using InspımoDesignPattern1.DAL;
using InspımoDesignPattern1.Models;

namespace InspımoDesignPattern1.ChainOfResponsibility
{
    public class AssistantManager : Employee
    {
       
            public override void ProcessRequest(CustomerProcessViewModel req)
            {
                var context = new Context();
                if (req.Amount <= 150000)
                {
                    CustomerProcess customerProcess = new CustomerProcess();
                    customerProcess.Amount = req.Amount;
                    customerProcess.CustomerName = req.CustomerName;
                    customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    customerProcess.EmployeeName = "Merve Çınar";
                    customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar müşteriye şube müdür yardımcısı tarafından ödendi, işlem kapatıldı.";
                context.customerProcesses.Add(customerProcess);
                    context.SaveChanges();
                }
                else if (NextApprover != null)
                {
                    CustomerProcess customerProcess = new CustomerProcess();
                    customerProcess.Amount = req.Amount;
                    customerProcess.CustomerName = req.CustomerName;
                    customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    customerProcess.EmployeeName = "Merve Çınar";
                    customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar şube müdür yardımcısı tarafından ödenemedi, işlem şube müdürüne yönlendirildi.";
                context.customerProcesses.Add(customerProcess);
                    context.SaveChanges();
                    NextApprover.ProcessRequest(req);
                }

            }
    }


}
