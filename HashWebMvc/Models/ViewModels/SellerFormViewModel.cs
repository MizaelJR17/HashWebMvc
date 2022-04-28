
using System.Collections.Generic;


namespace HashWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
       
        public ICollection<Department> Departments { get; set; }
    }
}
