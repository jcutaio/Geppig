using Geppig.Models;
using Geppig.RequestResponseObjects;

namespace Geppig.ResponseBuilders
{
    public interface IResponseBuilder
    {
        APIResponse BuildResponse(string jsonRequest);
    }
}