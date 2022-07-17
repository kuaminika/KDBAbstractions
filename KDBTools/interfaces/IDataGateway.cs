
using System.Collections.Generic;

namespace KDBTools.Repository.interfaces
{
    public interface IDataGateway
    {
        T ExecuteReadOneQuery<T>(string query);
        KWriteResult Execute(string query);
        KWriteResult ExecuteInsert(string query);
        List<T> ExecuteReadManyResult<T>(string query);

        void ExecuteScalar(string query, IKModelMapper mapper);

    }

}
