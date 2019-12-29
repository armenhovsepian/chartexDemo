using Chartex.Core.Entities;
using Chartex.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Chartex.Infrastructure.Data.Services
{
    public class UserTurnOverService : IUserTurnOverService
    {
        public IEnumerable<UserTurnOver> GetUserTurnOversById(int? userId)
        {
            // execute SP
            // Ex : using(var context = new ChartexEntities()) { ... }
            if (userId == null || userId == 0)
            {
                return Data.Take(50);
            }

            return Data.Where(x => x.UserId == userId.Value).ToList();
        }

        private IEnumerable<UserTurnOver> Data
        {
            get
            {
                for (var i = 1; i < 100; i++)
                {
                    yield return new UserTurnOver { Id = 1 * i, UserId = 5 * i, Amount = 10 * i };
                }
            }
        }
    }
}
