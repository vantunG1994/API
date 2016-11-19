using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.CategoryLocalhost;
using BusinessLogicLayer.Utilities;

namespace BusinessLogicLayer
{
    public class CategoryBusiness
    {
        private CategoryService service;

        public CategoryBusiness()
        {
            service = new CategoryService();
        }

        //Lấy danhs sách
        public List<CategoryDTO> GetCategoryList()
        {
            return service.GetListCategory().OrderBy(n => n.Id).ToList();
        }

        // Thêm
        public bool AddCategory(CategoryDTO pCategoryDTO)
        {
            return service.AddCategory(pCategoryDTO);
        }

        //Sửa
        public bool EditCategory(CategoryDTO pCategoryDTO)
        {
            return service.EditCategory(pCategoryDTO);
        }

        //Kiểm tra trùng tên
        public bool ExisCattName(string pCatName, int pCatID)
        {
            return service.ExisCattName(pCatName, pCatID);
        }
    }
}
