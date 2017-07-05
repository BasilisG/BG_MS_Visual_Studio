using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Models;

namespace Controllers
{
    public partial class VehicleTypeControllers
    {

        // Get VehicleType Details by VehicleTypeID

        public vmVehicleType GetVehicleTypeDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.VehicleTypes.AsNoTracking()
                        .FirstOrDefault(x => x.VehicleTypeID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Get VehicleTypes List
        public vmVehicleType[] GetVehicleTypesList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<VehicleType> oList = ctx.VehicleTypes.AsNoTracking();
                    oList = oList.Take(100);
                    var ans = oList.ToArray().Select(x => x.ToViewModel()).ToArray();
                    return ans;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Post VehicleType 
        public bool UpdateVehicleType(vmVehicleType vm)
        {
            VehicleType rec;
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
                                ctx.VehicleTypes.Add(new VehicleType().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.VehicleTypes.FirstOrDefault(x => x.VehicleTypeID == vm.VehicleTypeID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.VehicleTypes.FirstOrDefault(x => x.VehicleTypeID == vm.VehicleTypeID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.VehicleTypes.Attach(rec);
                            ctx.VehicleTypes.Remove(rec);
                            res = true;
                            break;
                    }
                    ctx.SaveChanges();
                    return res;
                }
            }
            catch (Exception ex)
            {

                return false;
                //return Failure("Η ενημέρωση των στοιχείων του Σκάφους απέτυχε.\nΑιτία : " + ex.Message);
            }
        }
    }
}

