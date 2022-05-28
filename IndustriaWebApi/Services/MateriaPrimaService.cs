using IndustriaWebApi.Data;
using IndustriaWebApi.Models.Entities;
using IndustriaWebApi.Services.Common;
using Microsoft.EntityFrameworkCore;

namespace IndustriaWebApi.Services
{
    public class MateriaPrimaService : IService<MateriaPrima>
    {
        private IndustriaContext _context;

        public MateriaPrimaService(IndustriaContext _context)
        {
            this._context = _context;
        }

        public void Create(MateriaPrima model)
        {
            _context.Set<MateriaPrima>().Add(model);
        }

        public IQueryable<MateriaPrima> GetAll()
        {
            return _context.Set<MateriaPrima>().AsNoTracking().AsQueryable();
        }

        private IQueryable<MateriaPrima> NewMethod()
        {
            return _context.Set<MateriaPrima>().AsNoTracking().AsQueryable();
        }

        public MateriaPrima GetById(Guid Id)
        {
            return _context.Set<MateriaPrima>().Where(p => p.Id == Id).AsNoTracking().FirstOrDefault();
        }

        public void Remove(MateriaPrima model)
        {
            _context.Set<MateriaPrima>().Remove(model);
            _context.SaveChanges();
        }

        public void Update(MateriaPrima model)
        {
            _context.Set<MateriaPrima>().Update(model);
            _context.SaveChanges();
        }
    }
}
