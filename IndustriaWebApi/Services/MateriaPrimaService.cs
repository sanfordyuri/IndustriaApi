using AutoMapper;
using IndustriaWebApi.Data;
using IndustriaWebApi.Models.Dtos;
using IndustriaWebApi.Models.Entities;
using IndustriaWebApi.Services.Common;
using Microsoft.EntityFrameworkCore;

namespace IndustriaWebApi.Services
{
    public class MateriaPrimaService : IService<MateriaPrimaDto>
    {
        private IndustriaContext _context;
        private IMapper _mapper;

        public MateriaPrimaService(IndustriaContext _context, IMapper _mapper)
        {
            this._mapper = _mapper;
            this._context = _context;
        }

        public void Create(MateriaPrimaDto model)
        {
            MateriaPrima produto = _mapper.Map<MateriaPrima>(model);
            _context.Set<MateriaPrima>().Add(produto);
            _context.SaveChanges();
        }

        public IQueryable GetAll()
        {
            return _context.Set<MateriaPrima>().AsNoTracking().AsQueryable();
        }

        public MateriaPrimaDto GetById(Guid Id)
        {
            return _mapper.Map<MateriaPrimaDto>(_context.Set<MateriaPrima>().Where(p => p.Id == Id)
                .AsNoTracking().FirstOrDefault());
        }

        public void Remove(MateriaPrimaDto model)
        {
            _context.Set<MateriaPrima>().Remove(_mapper.Map<MateriaPrima>(model));
            _context.SaveChanges();
        }

        public void Update(MateriaPrimaDto model)
        {
            _context.Set<MateriaPrima>().Update(_mapper.Map<MateriaPrima>(model));
            _context.SaveChanges();
        }
    }
}
