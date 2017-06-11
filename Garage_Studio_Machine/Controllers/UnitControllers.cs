using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ViewModels;

namespace Controllers
{
    public partial class UnitControllers
    {

        //  Get Unit Details by UnitID
        public vmUnit GetUnitDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Units.AsNoTracking()
                        .FirstOrDefault(x => x.UnitID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        // Get Units List
        public vmUnit[] GetUnitsList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Unit> oList = ctx.Units.AsNoTracking();
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

        // Post Unit 
        public bool UpdateUnit(vmUnit vm)
        {
            Unit rec;
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
                                ctx.Units.Add(new Unit().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Units.FirstOrDefault(x => x.UnitID == vm.UnitID );
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Units.FirstOrDefault(x => x.UnitID == vm.UnitID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Units.Attach(rec);
                            ctx.Units.Remove(rec);
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
