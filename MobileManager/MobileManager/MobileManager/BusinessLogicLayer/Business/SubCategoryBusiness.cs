using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.SubCategoryLocalhost;
using BusinessLogicLayer.Utilities;


namespace BusinessLogicLayer.Business
{
    public class SubCategoryBusiness
    {
        private SubCategoryService service;

        public SubCategoryBusiness()
        {
            service = new SubCategoryService();
        }

        //Lấy danhs sách
        public List<SubCategoryDTO> GetSubCategoryList()
        {
            return service.GetListSubCategory().OrderBy(n => n.Id).ToList();
        }

        // Thêm
        public bool AddSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            return service.AddSubCategory(pSubCategoryDTO);
        }

        //Sửa
        public bool EditSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            return service.EditSubCategory(pSubCategoryDTO);
        }

        //Kiểm tra trùng tên
        public bool ExisSubName(string pSubName, int pSubID)
        {
            return service.ExisSubName(pSubName, pSubID);
        }
    }
}
