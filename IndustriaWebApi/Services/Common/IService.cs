namespace IndustriaWebApi.Services.Common
{
    public interface IService<TModel>
    {
        void Create(TModel model);

        void Update(TModel model);

        void Remove(TModel model);

        IQueryable<TModel> GetAll();

        TModel GetById(Guid Id);
    }
}
