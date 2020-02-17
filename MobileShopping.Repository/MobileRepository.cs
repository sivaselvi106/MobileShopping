using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileShopping.entity;
namespace MobileShopping.Repository
{
    public class MobileRepository
    {
        public static List<Mobile> mobiles = new List<Mobile>();
        static MobileRepository()
        {
            mobiles.Add(new Mobile { BrandName = "Samsung", Model = "A50", Id=1, Color = "Blue", Price = 15000 });
            mobiles.Add(new Mobile { BrandName = "Redmi", Model = "Note5 Pro", Id = 2, Color = "White", Price = 10000 });
            mobiles.Add(new Mobile { BrandName = "Moto", Model = "G4+", Id = 3, Color = "Blue", Price = 9000 });
        }
        public IEnumerable<Mobile> GetMobileDetails()
        {
            return mobiles;
        }
        public void AddMobile(Mobile mobile)
        {
            mobiles.Add(mobile);
        }
        public Mobile GetMobileId(int mobileId)
        {
            return mobiles.Find(id => id.Id == mobileId);
        }
        public void DeleteMobile(int mobileId)
        {
            Mobile list = GetMobileId(mobileId);
            if (list != null)
                mobiles.Remove(list);
        }
    }
}

