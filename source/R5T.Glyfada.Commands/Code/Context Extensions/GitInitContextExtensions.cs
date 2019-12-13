using System;

using R5T.Heraklion;


namespace R5T.Glyfada.Commands
{
    public static class GitInitContextExtensions
    {
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
