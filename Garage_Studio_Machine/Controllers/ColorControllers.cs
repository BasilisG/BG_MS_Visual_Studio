using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Models;

namespace Controllers
{
    public partial class ColorControllers
    {

        // Get Color Details by ColorID

        public vmColor GetColorDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Colors.AsNoTracking()
                        .FirstOrDefault(x => x.ColorID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Get Colors List
        public vmColor[] GetColorsList()
         {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Color> oList = ctx.Colors.AsNoTracking();
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

        // Post Color 
        public bool UpdateColor(vmColor vm)
        {
            Color rec;
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
                                ctx.Colors.Add(new Color().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Colors.FirstOrDefault(x => x.ColorID == vm.ColorID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Colors.FirstOrDefault(x => x.ColorID == vm.ColorID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Colors.Attach(rec);
                            ctx.Colors.Remove(rec);
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
