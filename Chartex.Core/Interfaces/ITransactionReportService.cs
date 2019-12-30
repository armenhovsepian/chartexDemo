using System.Collections.Generic;
using Chartex.Core.Entities;

namespace Chartex.Core.Interfaces
{
    public interface ITransactionReportService
    {
        IEnumerable<UserTurnOver> GetTransactionReportByUserId(int? userId);
    }
}
