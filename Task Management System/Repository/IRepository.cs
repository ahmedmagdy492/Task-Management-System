using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Models;

namespace Task_Management_System.Repository
{
    public interface IRepository<TModel, TID> where TModel : BaseModel<TID>
    {
        IEnumerable<TModel> GetAll(Func<TModel, bool> filter = null, Func<TModel, TID> orderBy = null, string includeProps = null);
        TModel GetOne(Func<TModel, bool> filter, string includeProps = null);
        TModel Add(TModel entity);
        void Remove(TModel entity);
        void Remove(TID id);
    }
}
