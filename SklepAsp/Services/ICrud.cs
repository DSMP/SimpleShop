using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAsp.Services
{
    public interface ICrud<T>
    {
        void Create(T objectToCreate);
        T Read(long id);
        void Update(long id, T toUpdate);
        void Delete(long id);
        void Delete(T objectToDelete);
    }
}
