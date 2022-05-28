using IndustriaWebApi.Data;
using IndustriaWebApi.Models.Entities;
using IndustriaWebApi.Services.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IndustriaWebApi.Services
{
    public class ProdutoService : IService<Produto>
    {
        private IndustriaContext _context;

        public ProdutoService(IndustriaContext _context)
        {
            this._context = _context;
        }

        public void Create(Produto model)
        {
            _context.Set<Produto>().Add(model);   
        }

        public IQueryable<Produto> GetAll()
        {
            return _context.Set<Produto>().AsNoTracking().AsQueryable();
        }

        public Produto GetById(Guid Id)
        {
            return _context.Set<Produto>().Where(p => p.Id == Id).AsNoTracking().FirstOrDefault();
        }

        public void Remove(Produto model)
        {
            _context.Set<Produto>().Remove(model);
            _context.SaveChanges();
        }

        public void Update(Produto model)
        {
            _context.Set<Produto>().Update(model);
            _context.SaveChanges();
        }
    }
}
