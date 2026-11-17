using BackOffice.Areas.Catalog.Models.ViewModel;

namespace BackOffice.Areas.Catalog.Models
{
    public class MenuList
    {
        public IEnumerable<MenuViewModel> menuList { get; set; }
        public int totalCount { get; set; }
    }
}
