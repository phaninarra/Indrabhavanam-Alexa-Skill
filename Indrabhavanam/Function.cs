using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Indrabhavanam
{
    public class Function
    {
        /// <summary>
        /// A simple function that takes a input and returns an output
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public System.IO.Stream FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            context.Logger.LogLine("Entered the function handler");
            context.Logger.LogLine("This is the request: " + JsonConvert.SerializeObject(input));

            var output = JsonConvert.DeserializeObject<PlainTextSkillResponse>("{" +
  "\"response\": {" +
                "\"outputSpeech\": {" +
                    "\"type\": \"PlainText\"," +
      "\"text\": \"Welcome to the Alexa Skills Kit, you can say hello\"" +
                "}," +
    "\"reprompt\": {" +
                    "\"outputSpeech\": {" +
                        "\"type\": \"PlainText\"," +
        "\"text\": \"Go ahead and say hello to me!\"" +
                    "}" +
                "}," +
    "\"shouldEndSession\": false" +
  "}," +
  "\"version\": \"1.0\"," +
  "\"sessionAttributes\": {}" +
        "}");

            System.IO.Stream responseStream = new System.IO.MemoryStream();
            ILambdaSerializer serializer = new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer();
            serializer.Serialize(output, responseStream);

            context.Logger.LogLine("This is the response: " + JsonConvert.SerializeObject(output));

            return responseStream;
        }
    }
}
