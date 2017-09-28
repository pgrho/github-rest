using System;
using Xunit;

namespace Shipwreck.GithubClient.Events
{
    public sealed class WatchEventPayloadTest : ActivityPayloadTest
    {
        [Fact]
        public void SampleDataTest()
        {
            var actual = ReadAs<WatchEventPayload>("WatchEvent.json");
            Assert.Equal(WatchAction.Started, actual.Action);
            Assert.Equal(35129377, actual.Repository.Id);
            Assert.Equal("public-repo", actual.Repository.Name);
            Assert.Equal("baxterthehacker/public-repo", actual.Repository.FullName);
            Assert.Equal("baxterthehacker", actual.Repository.Owner.Login);
            Assert.Equal(6752317, actual.Repository.Owner.Id);
            Assert.Equal("https://avatars.githubusercontent.com/u/6752317?v=3", actual.Repository.Owner.AvatarUrl);
            Assert.Equal("", actual.Repository.Owner.GravatarId);
            Assert.Equal("https://api.github.com/users/baxterthehacker", actual.Repository.Owner.Url);
            Assert.Equal("https://github.com/baxterthehacker", actual.Repository.Owner.HtmlUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/followers", actual.Repository.Owner.FollowersUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/following{/other_user}", actual.Repository.Owner.FollowingUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/gists{/gist_id}", actual.Repository.Owner.GistsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/starred{/owner}{/repo}", actual.Repository.Owner.StarredUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/subscriptions", actual.Repository.Owner.SubscriptionsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/orgs", actual.Repository.Owner.OrganizationsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/repos", actual.Repository.Owner.ReposUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/events{/privacy}", actual.Repository.Owner.EventsUrl);
            Assert.Equal("https://api.github.com/users/baxterthehacker/received_events", actual.Repository.Owner.ReceivedEventsUrl);
            Assert.Equal(AccountType.User, actual.Repository.Owner.Type);
            Assert.Equal(false, actual.Repository.Owner.SiteAdmin);
            Assert.Equal(false, actual.Repository.Private);
            Assert.Equal("https://github.com/baxterthehacker/public-repo", actual.Repository.HtmlUrl);
            Assert.Equal("", actual.Repository.Description);
            Assert.Equal(false, actual.Repository.Fork);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo", actual.Repository.Url);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/forks", actual.Repository.ForksUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/keys{/key_id}", actual.Repository.KeysUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/collaborators{/collaborator}", actual.Repository.CollaboratorsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/teams", actual.Repository.TeamsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/hooks", actual.Repository.HooksUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/issues/events{/number}", actual.Repository.IssueEventsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/events", actual.Repository.EventsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/assignees{/user}", actual.Repository.AssigneesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/branches{/branch}", actual.Repository.BranchesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/tags", actual.Repository.TagsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/git/blobs{/sha}", actual.Repository.BlobsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/git/tags{/sha}", actual.Repository.GitTagsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/git/refs{/sha}", actual.Repository.GitRefsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/git/trees{/sha}", actual.Repository.TreesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/statuses/{sha}", actual.Repository.StatusesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/languages", actual.Repository.LanguagesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/stargazers", actual.Repository.StargazersUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/contributors", actual.Repository.ContributorsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/subscribers", actual.Repository.SubscribersUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/subscription", actual.Repository.SubscriptionUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/commits{/sha}", actual.Repository.CommitsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/git/commits{/sha}", actual.Repository.GitCommitsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/comments{/number}", actual.Repository.CommentsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/issues/comments{/number}", actual.Repository.IssueCommentUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/contents/{+path}", actual.Repository.ContentsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/compare/{base}...{head}", actual.Repository.CompareUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/merges", actual.Repository.MergesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/{archive_format}{/ref}", actual.Repository.ArchiveUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/downloads", actual.Repository.DownloadsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/issues{/number}", actual.Repository.IssuesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/pulls{/number}", actual.Repository.PullsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/milestones{/number}", actual.Repository.MilestonesUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/notifications{?since,all,participating}", actual.Repository.NotificationsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/labels{/name}", actual.Repository.LabelsUrl);
            Assert.Equal("https://api.github.com/repos/baxterthehacker/public-repo/releases{/id}", actual.Repository.ReleasesUrl);
            Assert.Equal(DateTimeOffset.Parse("2015/05/05 23:40:12z"), actual.Repository.CreatedAt);
            Assert.Equal(DateTimeOffset.Parse("2015/05/05 23:40:30z"), actual.Repository.UpdatedAt);
            Assert.Equal(DateTimeOffset.Parse("2015/05/05 23:40:27z"), actual.Repository.PushedAt);
            Assert.Equal("git://github.com/baxterthehacker/public-repo.git", actual.Repository.GitUrl);
            Assert.Equal("git@github.com:baxterthehacker/public-repo.git", actual.Repository.SshUrl);
            Assert.Equal("https://github.com/baxterthehacker/public-repo.git", actual.Repository.CloneUrl);
            Assert.Equal("https://github.com/baxterthehacker/public-repo", actual.Repository.SvnUrl);
            Assert.Equal(null, actual.Repository.Homepage);
            Assert.Equal(0, actual.Repository.Size);
            Assert.Equal(0, actual.Repository.StargazersCount);
            Assert.Equal(0, actual.Repository.WatchersCount);
            Assert.Equal(null, actual.Repository.Language);
            Assert.Equal(true, actual.Repository.HasIssues);
            Assert.Equal(true, actual.Repository.HasDownloads);
            Assert.Equal(true, actual.Repository.HasWiki);
            Assert.Equal(true, actual.Repository.HasPages);
            Assert.Equal(0, actual.Repository.ForksCount);
            Assert.Equal(null, actual.Repository.MirrorUrl);
            Assert.Equal(2, actual.Repository.OpenIssuesCount);
            Assert.Equal(0, actual.Repository.Forks);
            Assert.Equal(2, actual.Repository.OpenIssues);
            Assert.Equal(0, actual.Repository.Watchers);
            Assert.Equal("master", actual.Repository.DefaultBranch);
            Assert.Equal("baxterthehacker", actual.Sender.Login);
            Assert.Equal(6752317, actual.Sender.Id);
            Assert.Equal("https://avatars.githubusercontent.com/u/6752317?v=3", actual.Sender.AvatarUrl);
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
        }
    }
}