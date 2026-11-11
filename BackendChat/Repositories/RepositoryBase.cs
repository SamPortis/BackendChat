using Google.Cloud.Firestore;

namespace BackendChat.Api.Repositories
{
    public abstract class RepositoryBase<TEntity, TDto>(FirestoreDb db, string collectionName) 
        : IRepository<TEntity, TDto> 
        where TEntity : class
        where TDto : class
    {
        protected readonly CollectionReference _collection = db.Collection(collectionName);

        public Task<int> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(TDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(string id, TDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
