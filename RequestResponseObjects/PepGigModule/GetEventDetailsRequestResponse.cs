using System.Collections.Generic;
using Geppig.Models.PepGigModule;
using System;
using Geppig.RequestResponseObjects;

namespace Geppig.RequestResponseObjects.PepGigModule
{
    public class GetEventDetailsRequest
    {
        public string GroupGUID { get; set; }
        public string MemberGUID { get; set; }
        public string EventGUID { get; set; }
    }

    public class GetEventDetailsResponse : APIResponse
    {
        public EventDetails Event;
    }
}