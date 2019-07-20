using SklepAsp.Models;
using SklepAsp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SklepAsp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void Create(Stream imageStream, string fileName)
        {
            using (var binaryReader = new BinaryReader(imageStream))
            {
                File.WriteAllBytes(fileName, binaryReader.ReadBytes(Convert.ToInt32(imageStream.Length)));
            }
        }

        public void Create(Product objectToCreate)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product objectToDelete)
        {
            throw new NotImplementedException();
        }

        public Product Read(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(long id, Product toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}