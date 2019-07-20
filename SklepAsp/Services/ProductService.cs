using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using SklepAsp.Models;
using SklepAsp.Repositories;

namespace SklepAsp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly SklepAspContext _sklepAspContext;

        public ProductService(IProductRepository productRepository, SklepAspContext sklepAspContext)
        {
            _productRepository = productRepository;
            _sklepAspContext = sklepAspContext;
        }
        public void Create(Product objectToCreate, Stream imageStream, string imageContentType, string basePath)
        {
            try
            {
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }
                string fileName = Path.Combine(Guid.NewGuid() + "." + imageContentType.Split('/')[1]);
                objectToCreate.Image = fileName;
                _sklepAspContext.Products.Add(objectToCreate);
                _sklepAspContext.SaveChanges();
                _productRepository.Create(imageStream, Path.Combine(basePath, fileName));

            }
            catch (Exception ex)
            {
                throw;
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