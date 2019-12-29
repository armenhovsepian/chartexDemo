using System.Collections.Generic;
using Chartex.Core.Entities;

namespace Chartex.Core.Interfaces
{
    public interface IUserTurnOverService
    {
        IEnumerable<UserTurnOver> GetUserTurnOversById(int? userId);
    }
}
