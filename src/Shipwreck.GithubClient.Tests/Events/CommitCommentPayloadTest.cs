using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xunit;

namespace Shipwreck.GithubClient.Events
{

    public sealed class CommitCommentPayloadTest : ActivityPayloadTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var e = ReadAs<CommitCommentPayload>("CommitCommentEvent.json");

            Assert.Equal(EditAction.Created, e.Action);
        }
    }

}