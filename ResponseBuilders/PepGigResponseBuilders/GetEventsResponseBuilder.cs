using System;
using Geppig.Models;

namespace Geppig.ResponseBuilders
{
    public class GetEventsResponseBuilder : IResponseBuilder
    {
        public APIResponse BuildResponse(string jsonRequest)
        {
            return new APIResponse();
        }
    }
}
