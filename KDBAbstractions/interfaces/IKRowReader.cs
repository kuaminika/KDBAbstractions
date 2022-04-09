namespace KDBAbstractions.Repository.interfaces
{
    public interface IKRowReader
    {
        bool YieldedResults { get; }
        bool Read();

    }
}