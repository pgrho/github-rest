using Xunit;

namespace Shipwreck.GithubClient.Events
{
    public sealed class MembershipEventPayloadTest : ActivityPayloadTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var actual = ReadAs<MembershipEventPayload>("MembershipEvent.json");
            Assert.Equal(CollectionAction.Added, actual.Action);
            Assert.Equal("team", actual.Scope);
            Assert.Equal("kdaigle", actual.Member.Login);
            Assert.Equal(2501, actual.Member.Id);
            Assert.Equal("https://avatars.githubusercontent.com/u/2501?v=3", actual.Member.AvatarUrl);
            Assert.Equal("", actual.Member.GravatarId);
            Assert.Equal("https://api.github.com/users/kdaigle", actual.Member.Url);
            Assert.Equal("https://github.com/kdaigle", actual.Member.HtmlUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/followers", actual.Member.FollowersUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/following{/other_user}", actual.Member.FollowingUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/gists{/gist_id}", actual.Member.GistsUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/starred{/owner}{/repo}", actual.Member.StarredUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/subscriptions", actual.Member.SubscriptionsUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/orgs", actual.Member.OrganizationsUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/repos", actual.Member.ReposUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/events{/privacy}", actual.Member.EventsUrl);
            Assert.Equal("https://api.github.com/users/kdaigle/received_events", actual.Member.ReceivedEventsUrl);
            Assert.Equal(AccountType.User, actual.Member.Type);
            Assert.Equal(true, actual.Member.SiteAdmin);
            Assert.Equal("baxterthehacker", actual.Sender.Login);
            Assert.Equal(6752317, actual.Sender.Id);
            Assert.Equal("https://avatars.githubusercontent.com/u/6752317?v=2", actual.Sender.AvatarUrl);
            Assert.Equal("", actual.Sender.GravatarId);
            Assert.Equal("https://api.github.com/users/baxterthehacker", actual.Sender.Url);
            Assert.Equal("https://github.com/baxterthehacker", actual.Sender.HtmlUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/followers", actual.Sender.FollowersUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/following{/other_user}", actual.Sender.FollowingUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/gists{/gist_id}", actual.Sender.GistsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/starred{/owner}{/repo}", actual.Sender.StarredUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/subscriptions", actual.Sender.SubscriptionsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/orgs", actual.Sender.OrganizationsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/repos", actual.Sender.ReposUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/events{/privacy}", actual.Sender.EventsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/received_events", actual.Sender.ReceivedEventsUrl);
            Assert.Equal(AccountType.User, actual.Sender.Type);
            Assert.Equal(false, actual.Sender.SiteAdmin);
            Assert.Equal("Contractors", actual.Team.Name);
            Assert.Equal(123456, actual.Team.Id);
            Assert.Equal("contractors", actual.Team.Slug);
            Assert.Equal(Permission.Admin, actual.Team.Permission);
            Assert.Equal("https://api.github.com/teams/123456", actual.Team.Url);
            Assert.Equal("https://api.github.com/teams/123456/members{/member}", actual.Team.MembersUrl);
            Assert.Equal("https://api.github.com/teams/123456/repos", actual.Team.RepositoriesUrl);
            Assert.Equal("baxterandthehackers", actual.Organization.Login);
            Assert.Equal(7649605, actual.Organization.Id);
            Assert.Equal("https://api.github.com/orgs/baxterandthehackers", actual.Organization.Url);
            Assert.Equal("https://api.github.com/orgs/baxterandthehackers/repos", actual.Organization.ReposUrl);
            Assert.Equal("https://api.github.com/orgs/baxterandthehackers/events", actual.Organization.EventsUrl);
            Assert.Equal("https://api.github.com/orgs/baxterandthehackers/members{/member}", actual.Organization.MembersUrl);
            Assert.Equal("https://api.github.com/orgs/baxterandthehackers/public_members{/member}", actual.Organization.PublicMembersUrl);
            Assert.Equal("https://avatars.githubusercontent.com/u/7649605?v=2", actual.Organization.AvatarUrl);
        }
    }
}