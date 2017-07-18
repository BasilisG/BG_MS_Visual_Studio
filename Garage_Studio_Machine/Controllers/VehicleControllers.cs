using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Models;

namespace Controllers
{
    public partial class VehicleControllers
    {
        // Get Vehicle Details by VehicleID
        public vmVehicle GetVehicleDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Vehicles.AsNoTracking()
                        .FirstOrDefault(x => x.VehicleID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Get Vehicles List
        public vmVehicle[] GetVehiclesList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Vehicle> oList = ctx.Vehicles.AsNoTracking();
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

        // Update / Post Vehicle
        public bool UpdateVehicle(vmVehicle vm)
        {
            Vehicle rec;
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
                                ctx.Vehicles.Add(new Vehicle().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Vehicles.FirstOrDefault(x => x.VehicleID == vm.VehicleID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Vehicles.FirstOrDefault(x => x.VehicleID == vm.VehicleID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Vehicles.Attach(rec);
                            ctx.Vehicles.Remove(rec);
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
