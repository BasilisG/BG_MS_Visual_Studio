using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ViewModels;

namespace Controllers
{
    public partial class CustomerControllers
    {
        // Get Customer Details by CustomerID
        public vmCustomer GetCustomerDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Customers.AsNoTracking()
                        .FirstOrDefault(x => x.CustomerID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Get Customers List
        public vmCustomer[] GetCustomersList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Customer> oList = ctx.Customers.AsNoTracking();
                    oList = oList.Take(500);
                    var ans = oList.ToArray().Select(x => x.ToViewModel()).ToArray();
                    return ans;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Update / Post Customer
        public bool UpdateCustomer(vmCustomer vm)
        {
            Customer rec;
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    Boolean res = false;
                    switch (vm.RowStatus)
                    {
                        case RecordMode.Added:
                            try
                            {
                                ctx.Customers.Add(new Customer().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Customers.FirstOrDefault(x => x.CustomerID == vm.CustomerID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Customers.FirstOrDefault(x => x.CustomerID == vm.CustomerID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Customers.Attach(rec);
                            ctx.Customers.Remove(rec);
                            res = true;
                            break;
                    }
                    ctx.SaveChanges();
                    return res;
                }
            }
            catch (Exception)
            {
                return false;
                //return Failure("Η ενημέρωση των στοιχείων του Σκάφους απέτυχε.\nΑιτία : " + ex.Message);
            }
        }


    }
}
