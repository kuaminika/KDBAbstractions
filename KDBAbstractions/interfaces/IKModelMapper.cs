using MySql.Data.MySqlClient;

namespace KDBAbstractions.Repository.interfaces
{
    public interface IKModelMapper
    {
        void map(IKDataReader kdt);
    }
}