using System;
using Newtonsoft.Json;
using Geppig.Models;
using Geppig.RequestResponseObjects.PepGigModule;
using Geppig.RequestResponseObjects;
using Geppig.Models.PepGigModule;
using System.Collections.Generic;

namespace Geppig.ResponseBuilders
{
    public class GetEventListResponseBuilder : IResponseBuilder
    {
        public GetEventListRequest request { get; set; }
        public GetEventListResponse response { get; set; }
        public APIResponse BuildResponse(string jsonRequest)
        {
            request = JsonConvert.DeserializeObject<GetEventListRequest>(jsonRequest);

            //Get actual information from the database

            response = new GetEventListResponse();
            response.RequestName = "GetEventList";
            response.EventList = new List<EventSummary>();
            
            var event1 = new EventSummary();
            event1.Event = new Event() {Description = "FistDick Cybrosis", DateTime = new DateTime(), GroupGUID = "ec0a4e7d-62be-4647-8b05-68e589b7517c"};
            event1.IsMemberSignedUp = true;

            var event2 = new EventSummary();
            event2.Event = new Event() {Description = "GatorWalk", DateTime = new DateTime(), GroupGUID = "ec0a4e7d-62be-4647-8b05-68e589b7517c"};
            event2.IsMemberSignedUp = false;

            response.EventList.Add(event1);
            response.EventList.Add(event2);

            return response;
        }
    }
}
