namespace CNAPP.Service.Concrete
{
    public class SingletonContext<T> where T : class, new()
    {
        private T _dbContext;

        public T DbContext
        {
            get
            {
                if (_dbContext == null)
                    _dbContext = new T();
                return _dbContext;
            }
        }

    }
}
