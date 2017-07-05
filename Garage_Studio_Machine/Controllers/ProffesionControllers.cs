using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Models;

namespace Controllers
{
    class ProffesionControllers
    {
        // Get Proffesion Details by ProffesionID
        public vmProffesion GetProffesionDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Proffesions.AsNoTracking()
                        .FirstOrDefault(x => x.ProffesionID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Get Proffesion List
        public vmProffesion[] GetProffesionsList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Proffesion> oList = ctx.Proffesions.AsNoTracking();
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

        // Post Proffesion
        public bool UpdateProffesion(vmProffesion vm)
        {
            Proffesion rec;
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
                                ctx.Proffesions.Add(new Proffesion().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Proffesions.FirstOrDefault(x => x.ProffesionID == vm.ProffesionID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Proffesions.FirstOrDefault(x => x.ProffesionID == vm.ProffesionID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Proffesions.Attach(rec);
                            ctx.Proffesions.Remove(rec);
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
