using Xunit;

namespace Shipwreck.GithubClient.Events
{
    public sealed class InstallationRepositoriesPayloadTest : ActivityPayloadTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var actual = ReadAs<InstallationRepositoriesPayload>("InstallationRepositoriesEvent.json");

            Assert.Equal(CollectionAction.Removed, actual.Action);
            Assert.Equal(2, actual.Installation.Id);
            Assert.Equal("octocat", actual.Installation.Account.Login);
            Assert.Equal(1, actual.Installation.Account.Id);
            Assert.Equal("https://github.com/images/error/octocat_happy.gif", actual.Installation.Account.AvatarUrl);
            Assert.Equal("", actual.Installation.Account.GravatarId);
            Assert.Equal("https://api.github.com/users/octocat", actual.Installation.Account.Url);
            Assert.Equal("https://github.com/octocat", actual.Installation.Account.HtmlUrl);
            Assert.Equal("https://api.github.com/users/octocat/followers", actual.Installation.Account.FollowersUrl);
            Assert.Equal("https://api.github.com/users/octocat/following{/other_user}", actual.Installation.Account.FollowingUrl);
            Assert.Equal("https://api.github.com/users/octocat/gists{/gist_id}", actual.Installation.Account.GistsUrl);
            Assert.Equal("https://api.github.com/users/octocat/starred{/owner}{/repo}", actual.Installation.Account.StarredUrl);
            Assert.Equal("https://api.github.com/users/octocat/subscriptions", actual.Installation.Account.SubscriptionsUrl);
            Assert.Equal("https://api.github.com/users/octocat/orgs", actual.Installation.Account.OrganizationsUrl);
            Assert.Equal("https://api.github.com/users/octocat/repos", actual.Installation.Account.ReposUrl);
            Assert.Equal("https://api.github.com/users/octocat/events{/privacy}", actual.Installation.Account.EventsUrl);
            Assert.Equal("https://api.github.com/users/octocat/received_events", actual.Installation.Account.ReceivedEventsUrl);
            Assert.Equal(AccountType.User, actual.Installation.Account.Type);
            Assert.Equal(false, actual.Installation.Account.SiteAdmin);
            Assert.Equal(RepositorySelection.Selected, actual.Installation.RepositorySelection);
            Assert.Equal("https://api.github.com/installations/2/access_tokens", actual.Installation.AccessTokensUrl);
            Assert.Equal("https://api.github.com/installation/repositories", actual.Installation.RepositoriesUrl);
            Assert.Equal("https://github.com/settings/installations/2", actual.Installation.HtmlUrl);
            Assert.Equal(RepositorySelection.Selected, actual.RepositorySelection);
            Assert.Equal(1296269, actual.RepositoriesRemoved[0].Id);
            Assert.Equal("Hello-World", actual.RepositoriesRemoved[0].Name);
            Assert.Equal("octocat/Hello-World", actual.RepositoriesRemoved[0].FullName);
            Assert.Equal("octocat", actual.Sender.Login);
            Assert.Equal(1, actual.Sender.Id);
            Assert.Equal("https://github.com/images/error/octocat_happy.gif", actual.Sender.AvatarUrl);
            Assert.Equal("", actual.Sender.GravatarId);
            Assert.Equal("https://api.github.com/users/octocat", actual.Sender.Url);
            Assert.Equal("https://github.com/octocat", actual.Sender.HtmlUrl);
            Assert.Equal("https://api.github.com/users/octocat/followers", actual.Sender.FollowersUrl);
            Assert.Equal("https://api.github.com/users/octocat/following{/other_user}", actual.Sender.FollowingUrl);
            Assert.Equal("https://api.github.com/users/octocat/gists{/gist_id}", actual.Sender.GistsUrl);
            Assert.Equal("https://api.github.com/users/octocat/starred{/owner}{/repo}", actual.Sender.StarredUrl);
            Assert.Equal("https://api.github.com/users/octocat/subscriptions", actual.Sender.SubscriptionsUrl);
            Assert.Equal("https://api.github.com/users/octocat/orgs", actual.Sender.OrganizationsUrl);
            Assert.Equal("https://api.github.com/users/octocat/repos", actual.Sender.ReposUrl);
            Assert.Equal("https://api.github.com/users/octocat/events{/privacy}", actual.Sender.EventsUrl);
            Assert.Equal("https://api.github.com/users/octocat/received_events", actual.Sender.ReceivedEventsUrl);
            Assert.Equal(AccountType.User, actual.Sender.Type);
            Assert.Equal(false, actual.Sender.SiteAdmin);
        }
    }
}