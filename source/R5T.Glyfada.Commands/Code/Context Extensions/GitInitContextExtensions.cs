using System;

using R5T.Heraklion;
using R5T.Piraeus.Extensions;


namespace R5T.Glyfada.Commands
{
    public static class GitInitContextExtensions
    {
        public static ICommandBuilderContext<GitInitContext> SetDirectory(this ICommandBuilderContext<GitInitContext> gitInitContext, string directoryPath)
        {
            gitInitContext.CommandBuilder.AppendPath(directoryPath);

            return gitInitContext;
        }

        public static ICommandBuilderContext<GitInitContext> SetQuietShort(this ICommandBuilderContext<GitInitContext> gitInitContext)
        {
            gitInitContext.CommandBuilder.Append("-q");

            return gitInitContext;
        }

        public static ICommandBuilderContext<GitInitContext> SetQuietLong(this ICommandBuilderContext<GitInitContext> gitInitContext)
        {
            gitInitContext.CommandBuilder.Append("-quiet");

            return gitInitContext;
        }

        public static ICommandBuilderContext<GitInitContext> SetQuiet(this ICommandBuilderContext<GitInitContext> gitInitContext)
        {
            gitInitContext.SetQuietLong();

            return gitInitContext;
        }
    }
}
