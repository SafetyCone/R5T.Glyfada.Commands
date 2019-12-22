using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Glyfada.Commands
{
    public static class GitConfigContextExtensions
    {
        public static ICommandBuilderContext<GitConfigContext> Get(this ICommandBuilderContext<GitConfigContext> gitConfigContext, string parameterName)
        {
            gitConfigContext
                .AppendNameValuePair("--get", parameterName)
                ;

            return gitConfigContext;
        }

        public static ICommandBuilderContext<GitConfigContext> GetRemoteOriginUrl(this ICommandBuilderContext<GitConfigContext> gitConfigContext)
        {
            gitConfigContext.Get("remote.origin.url");

            return gitConfigContext;
        }

        public static ICommandBuilderContext<GitConfigContext> GetRemoteRepositoryUrl(this ICommandBuilderContext<GitConfigContext> gitConfigContext)
        {
            gitConfigContext.GetRemoteOriginUrl();

            return gitConfigContext;
        }
    }
}
