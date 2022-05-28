using AutoMapper;
using IndustriaWebApi.Data;
using IndustriaWebApi.Models.Dtos;
using IndustriaWebApi.Models.Entities;
using IndustriaWebApi.Services.Common;
using Microsoft.EntityFrameworkCore;

namespace IndustriaWebApi.Services
{
    public class ProdutoService : IService<ProdutoDto>
    {
        private IndustriaContext _context;
        private IMapper _mapper;

        public ProdutoService(IndustriaContext _context, IMapper _mapper)
        {
            this._mapper = _mapper;
            this._context = _context;
        }

        public void Create(ProdutoDto model)
        {
            Produto produto = _mapper.Map<Produto>(model);
            _context.Set<Produto>().Add(produto);
            _context.SaveChanges();
        }

        public IQueryable GetAll()
        {
            return _context.Set<Produto>().AsNoTracking().AsQueryable();
        }

        public ProdutoDto GetById(Guid Id)
        {
            return _mapper.Map<ProdutoDto>(_context.Set<Produto>().Where(p => p.Id == Id)
                .AsNoTracking().FirstOrDefault());
        }

        public void Remove(ProdutoDto model)
        {
            _context.Set<Produto>().Remove(_mapper.Map<Produto>(model));
            _context.SaveChanges();
        }

        public void Update(ProdutoDto model)
        {
            _context.Set<Produto>().Update(_mapper.Map<Produto>(model));
            _context.SaveChanges();
        }
    }
}
