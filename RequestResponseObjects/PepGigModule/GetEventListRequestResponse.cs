using System.Collections.Generic;
using Geppig.Models.PepGigModule;
using System;
using Geppig.RequestResponseObjects;

namespace Geppig.RequestResponseObjects.PepGigModule
{
    public class GetEventListRequest
    {
        public string GroupGUID { get; set; }
        public string MemberGUID { get; set; }
    }

    public class GetEventListResponse : APIResponse
    {
        public List<EventSummary> EventList;

    }
}