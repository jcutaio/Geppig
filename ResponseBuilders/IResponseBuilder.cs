using Geppig.Models;

namespace Geppig.ResponseBuilders
{
    public interface IResponseBuilder
    {
        APIResponse BuildResponse(string jsonRequest);
    }
}