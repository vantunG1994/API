using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccessLayer.Entity;
using DataAccessLayer.OTO;
using DataAccessLayer.Utilities_1;

namespace DataAccessLayer.Service
{
    /// <summary>
    /// Summary description for ItemService
    /// </summary>
    [WebService(Namespace = "http://ItemService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ItemService : System.Web.Services.WebService
    {

        public ItemService() { }
        private MobileEntities db;

        [WebMethod]
        public List<ItemDTO> GetListItem()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.ItemDTOList(db.ITEMs.ToList());
            }
        }

        [WebMethod]
        public bool AddItem(ItemDTO pItemDTO)
        {
            using (db = new MobileEntities())
            {
                ITEM item = DALUtilitiesMethod.ToItem(pItemDTO);
                try
                {
                    db.ITEMs.Add(item);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        [WebMethod]
        public bool ExisItemName(string pItemName, int pItemID)
        {
            using (db = new MobileEntities())
            {
                var n = db.ITEMs.SingleOrDefault(p => p.Name.Equals(pItemName) && p.Id != pItemID);
                if (n != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        [WebMethod]
        public bool EditItem(ItemDTO pItemDTO)
        {
            using (db = new MobileEntities())
            {
                ITEM item = db.ITEMs.SingleOrDefault(n => n.Id == pItemDTO.Id);
                if (item == null)
                {
                    return false;
                }
                try
                {
                    item.Id = pItemDTO.Id;
                    item.Name = pItemDTO.Name;
                    item.Ram = pItemDTO.Ram;
                    item.Pin = pItemDTO.Pin;
                    item.Camera = pItemDTO.Camera;
                    item.Cpu = pItemDTO.Cpu;
                    item.Price = pItemDTO.Price;
                    item.Image = pItemDTO.Image;
                    item.Quantity = pItemDTO.Quantity;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
