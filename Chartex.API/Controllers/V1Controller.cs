using System.Collections.Generic;
using System.Web.Http;
using Chartex.Core.Entities;
using Chartex.Core.Interfaces;
using Chartex.Infrastructure.Data.Services;

namespace Chartex.API.Controllers
{
    public class V1Controller : ApiController
    {
        private readonly IUserTurnOverService _userTurnOverService;

        public V1Controller()
        {
            // Use Dependency Injection
            _userTurnOverService = new UserTurnOverService();
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2#optional
        /// </summary>

        [Route("api/v1/GetUserTurnOver/{userId:int?}")]
        public IEnumerable<UserTurnOver> GetUserTurnOver(int? userId = 0)
        {
            return _userTurnOverService.GetUserTurnOversById(userId);
        }
    }
}
