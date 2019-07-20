using SklepAsp.Models;
using SklepAsp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepAsp.Repositories
{
    public interface IProductRepository : ICrud<Product>
    {
        void Create(Stream imageStream, string fileName);
    }
}
