using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, string id, 
TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    // Fetching the name from the path parameter in the request URL
    return req.CreateResponse(HttpStatusCode.OK, "Hello " + id);
}
