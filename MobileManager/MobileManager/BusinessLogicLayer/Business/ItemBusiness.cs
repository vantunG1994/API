using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.ItemIocalhost;
using BusinessLogicLayer.Utilities;

namespace BusinessLogicLayer.Business
{
    public class ItemBusiness
    {
        private ItemService service;

        public ItemBusiness()
        {
            service = new ItemService();
        }

        //Lấy danhs sách
        public List<ItemDTO> GetItemList()
        {
            return service.GetListItem().OrderBy(n => n.Id).ToList();
        }

        // Thêm
        public bool AddItem(ItemDTO pItemDTO)
        {
            return service.AddItem(pItemDTO);
        }

        //Sửa
        public bool EditItem(ItemDTO pItemDTO)
        {
            return service.EditItem(pItemDTO);
        }

        //Kiểm tra trùng tên
        public bool ExisItemName(string pItemName, int pItemID)
        {
            return service.ExisItemName(pItemName, pItemID);
        }
    }
}
