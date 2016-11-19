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
    /// Summary description for SubCategoryService
    /// </summary>
    [WebService(Namespace = "http://SubCategoryService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubCategoryService : System.Web.Services.WebService
    {
        public SubCategoryService() { }

        private MobileEntities db;
        [WebMethod]
        public List<SubCategoryDTO> GetListSubCategory()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.SubCategoryDTOList(db.SUBCATEGORies.ToList());
            }
        }

        [WebMethod]
        public bool AddSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = DALUtilitiesMethod.ToSubCategory(pSubCategoryDTO);
                try
                {
                    db.SUBCATEGORies.Add(subCategory);
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
        public bool ExisSubName(string pSubName, int pSubID)
        {
            using (db = new MobileEntities())
            {
                var n = db.SUBCATEGORies.SingleOrDefault(p => p.Name.Equals(pSubName) && p.Id != pSubID);
                if (n != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        [WebMethod]
        public bool EditSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == pSubCategoryDTO.Id);
                if (subCategory == null)
                {
                    return false;
                }
                try
                {
                    subCategory.CategoryId = pSubCategoryDTO.CategoryId;
                    subCategory.Name = pSubCategoryDTO.Name;
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
