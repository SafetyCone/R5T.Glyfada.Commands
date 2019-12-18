using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Glyfada.Commands
{
    public static class GitAddContextExtensions
    {
        public static ICommandBuilderContext<GitAddContext> AddPath(this ICommandBuilderContext<GitAddContext> gitAddContext, string path)
        {
            gitAddContext.AppendPath(path);

            return gitAddContext;
        }
    }
}
