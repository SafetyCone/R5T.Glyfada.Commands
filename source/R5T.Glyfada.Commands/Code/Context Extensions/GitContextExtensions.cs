using System;

using R5T.Heraklion;


namespace R5T.Glyfada.Commands
{
    public static class GitContextExtensions
    {
        public static ICommandBuilderContext<GitInitContext> Init(this ICommandBuilderContext<GitContext> gitContext)
        {
            gitContext.CommandBuilder.Append("init");

            var gitInitContext = gitContext.ChangeContext<GitInitContext>();
            return gitInitContext;
        }
    }
}
