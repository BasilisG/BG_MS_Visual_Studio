using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Models;

namespace Controllers
{
    public partial class ItemControllers
    {
        // Get Item Details by ItemID
        public vmItem GetItemDetails(string recID)
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    var ans = ctx.Items.AsNoTracking()
                        .FirstOrDefault(x => x.ItemID == new Guid(recID));
                    if (ans == null) return null;

                    return ans.ToViewModel();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Get Items List
        public vmItem[] GetItemsList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<Item> oList = ctx.Items.AsNoTracking();
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

        // Update / Post Item
        public bool UpdateItem(vmItem vm)
        {
            Item rec;
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
                                ctx.Items.Add(new Item().FromViewModel(vm));
                                res = true;
                            }
                            catch (Exception ex)
                            {
                                res = false;
                                throw ex;
                            }
                            break;
                        case RecordMode.Modified:

                            rec = ctx.Items.FirstOrDefault(x => x.ItemID == vm.ItemID);
                            if (rec == null)
                                return res = false;
                            rec.FromViewModel(vm);
                            res = true;
                            break;

                        case RecordMode.Deleted:
                            rec = ctx.Items.FirstOrDefault(x => x.ItemID == vm.ItemID);
                            if (rec == null)
                                res = false;
                            //                            
                            ctx.Items.Attach(rec);
                            ctx.Items.Remove(rec);
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
