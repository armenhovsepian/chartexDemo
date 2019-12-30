using System.Collections.Generic;
using System.Web.Http;
using Chartex.Core.Entities;
using Chartex.Core.Interfaces;
using Chartex.Infrastructure.Data.Services;

namespace Chartex.API.Controllers
{
    public class V1Controller : ApiController
    {
        private readonly ITransactionReportService _userTurnOverService;

        public V1Controller()
        {
            // Use Dependency Injection
            _userTurnOverService = new TransactionReportService();
        }

        [Route("api/v1/GetTransactionReport/{userId:int?}")]
        public IEnumerable<UserTurnOver> GetTransactionReport(int? userId = 0)
        {
            return _userTurnOverService.GetTransactionReportByUserId(userId);
        }
    }
}
