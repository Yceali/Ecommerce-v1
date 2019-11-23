using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Management.Models.Interface
{
    interface Irepository<T>  where T: BaseEntity
    {
        void Save(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        T Get(int Id);

        List<T> GetAll();
    }
}
