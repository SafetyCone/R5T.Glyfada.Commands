using System;

using R5T.Heraklion;
using R5T.Piraeus;


namespace R5T.Glyfada.Commands
{
    public static class GitCloneContextExtensions
    {
        public static ICommandBuilderContext<GitCloneContext> SetRepository(this ICommandBuilderContext<GitCloneContext> gitCloneContext, string repositoryURL)
        {
            gitCloneContext.CommandBuilder.Append(repositoryURL);

            return gitCloneContext;
        }

        public static ICommandBuilderContext<GitCloneContext> SetDirectory(this ICommandBuilderContext<GitCloneContext> gitCloneContext, string directoryPath)
        {
            gitCloneContext.CommandBuilder.AppendPath(directoryPath);

            return gitCloneContext;
        }

        public static ICommandBuilderContext<GitCloneContext> SetProgress(this ICommandBuilderContext<GitCloneContext> gitCloneContext)
        {
            gitCloneContext.CommandBuilder.Append("--progress");

            return gitCloneContext;
        }
    }
}
