using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Glyfada.Commands
{
    public static class GitCommitContextExtensions
    {
        public static ICommandBuilderContext<GitCommitContext> SetMessage(this ICommandBuilderContext<GitCommitContext> gitCommitContext, string message)
        {
            gitCommitContext.AppendNameQuotedValuePair("-m", message);

            return gitCommitContext;
        }
    }
}
