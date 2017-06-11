using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ViewModels;

namespace Controllers
{
    public class ItemTypeControllers
    {
        public vmItemType[] GetItemTypesList()
        {
            try
            {
                using (GarageContext ctx = new GarageContext())
                {
                    IQueryable<ItemType> oList = ctx.ItemTypes.AsNoTracking();
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

    }
}
