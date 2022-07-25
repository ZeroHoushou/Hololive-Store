using Hololive_Store.Common.Entities;
using System;
using Hololive_Store.Web.Models;

namespace Hololive_Store.Web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);
    }

}
