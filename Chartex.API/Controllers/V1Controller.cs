using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Chartex.Core.Entities;
using Chartex.Core.Interfaces;
using Chartex.Infrastructure.Data.Services;

namespace Chartex.API.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    //[EnableCors(origins: "https://localhost:44316/", headers: "*", methods: "*")]
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
            var data = _userTurnOverService.GetTransactionReportByUserId(userId);
            return data;
        }
    }
}
