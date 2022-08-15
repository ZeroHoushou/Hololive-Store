using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Hololive_Store.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();
    }

}
