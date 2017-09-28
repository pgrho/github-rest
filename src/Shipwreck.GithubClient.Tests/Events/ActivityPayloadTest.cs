using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xunit;

namespace Shipwreck.GithubClient.Events
{
    public abstract class ActivityPayloadTest
    {
        protected T ReadAs<T>(string fileName)
        {
            using (var s = GetType().GetTypeInfo().Assembly.GetManifestResourceStream(GetType().Namespace + "." + fileName))
            using (var sr = new StreamReader(s))
            using (var jr = new JsonTextReader(sr))
            {
                return new JsonSerializer().Deserialize<T>(jr);
            }
        }
    }

}