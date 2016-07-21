using System;
using Newtonsoft.Json;
using Geppig.Models;
using Geppig.RequestResponseObjects.PepGigModule;
using Geppig.RequestResponseObjects;
using Geppig.Models.PepGigModule;
using System.Collections.Generic;

namespace Geppig.ResponseBuilders
{
    public class GetEventDetailsResponseBuilder : IResponseBuilder
    {
        public GetEventDetailsRequest request { get; set; }
        public GetEventDetailsResponse response { get; set; }
        public APIResponse BuildResponse(string jsonRequest)
        {
            request = JsonConvert.DeserializeObject<GetEventDetailsRequest>(jsonRequest);

            //Get actual information from the database

            response = new GetEventDetailsResponse();
            response.RequestName = "GetEventDetails";
            response.Event = new EventDetails();

            return response;
        }
    }
}
