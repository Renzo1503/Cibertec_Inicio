using System.Collections.Generic;


namespace WebDeveloper.DataAccess
{
    interface IDataAccess<T>
    {
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
    }
}
