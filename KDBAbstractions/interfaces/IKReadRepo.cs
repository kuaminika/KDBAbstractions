
using System.Collections.Generic;

namespace KDBAbstractions.Repository.interfaces
{
    interface IKReadRepo<T>
    {
        List<T> Get(T queryObj);
    }
}
