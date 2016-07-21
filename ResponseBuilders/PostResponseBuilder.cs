using Geppig.Models;
using Newtonsoft.Json;
using Geppig.RequestResponseObjects;

namespace Geppig.ResponseBuilders
{

    public class PostResponseBuilder
    {
        public static string BuildJsonResponse(string id, string jsonRequest)
        {
            IResponseBuilder responseBuilder = GetResponseBuilder(id);

            APIResponse response = responseBuilder.BuildResponse(jsonRequest);

            return JsonConvert.SerializeObject(response);
        }

        public static IResponseBuilder GetResponseBuilder(string id)
        {
            switch (id)
            {
                case "GetEventList":
                    return new GetEventListResponseBuilder();
                case "GetEventDetails":
                    return new GetEventDetailsResponseBuilder();

                default:
                    return null;
            }
        }
    }
}
