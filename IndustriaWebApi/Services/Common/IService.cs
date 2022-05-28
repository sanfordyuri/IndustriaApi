namespace IndustriaWebApi.Services.Common
{
    public interface IService<TModel>
    {
        void Create(TModel model);

        void Update(TModel model);

        void Remove(TModel model);

        IQueryable GetAll();

        TModel GetById(Guid Id);
    }
}
