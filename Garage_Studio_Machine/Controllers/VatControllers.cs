using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ViewModels;

namespace Controllers
{
    public partial class VatControllers
    {
        // Get Vat Details by VartID
        public vmVat GetVatDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Vats.AsNoTracking()
                        .FirstOrDefault(x => x.VatID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Get Vats List
        public vmVat[] GetVatsList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Vat> oLIst = ctx.Vats.AsNoTracking();
                    oLIst = oLIst.Take(100);
                    var ans = oLIst.ToArray().Select(x => x.ToViewModel()).ToArray();
                    return ans;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Post Vat
        public bool UpdateVat(vmVat vm)
        {
            Vat rec;
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
                                ctx.Vats.Add(new Vat().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Vats.FirstOrDefault(x => x.VatID == vm.VatID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Vats.FirstOrDefault(x => x.VatID == vm.VatID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Vats.Attach(rec);
                            ctx.Vats.Remove(rec);
                            res = true;
                            break;
                    }
                    ctx.SaveChanges();
                    return res;
                }
            }
            catch (Exception )
            {
                return false;
                //return Failure("Η ενημέρωση των στοιχείων του Σκάφους απέτυχε.\nΑιτία : " + ex.Message);
            }
        }
    
    }
}
