using InspımoDesignPattern1.DAL;
using InspımoDesignPattern1.Models;

namespace InspımoDesignPattern1.ChainOfResponsibility
{
    public class RegionManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            var context = new Context();
            if (req.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                customerProcess.EmployeeName = "Serkan Kaya";
                customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar müşteriye bölge müdürü tarafından ödendi, işlem kapatıldı.";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                customerProcess.EmployeeName = "Serkan Kaya";
                customerProcess.EmployeeDescription = "Müşterinin talep ettiği tutar bölge müdürü tarafından ödenemedi, işlem yapılamadı.";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();               
            }
        }
    }
}
