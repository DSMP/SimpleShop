using SklepAsp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAsp.Services
{
    public interface IProductService : ICrud<Product>
    {
        void Create(Product objectToCreate, Stream imageStream, string imageContentType);
    }
}
