using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Glyfada.Commands
{
    public static class GitContextExtensions
    {
        public static ICommandBuilderContext<GitAddContext> Add(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitAddContext = gitContext
                .Append("add")
                .ChangeContext<GitAddContext>()
                ;

            return gitAddContext;
        }

        public static ICommandBuilderContext<GitAddContext> Add(this ICommandBuilderContext<GitContext> gitContext, string path)
        {
            var gitAddContext = gitContext
                .Add()
                .AddPath(path)
                ;

            return gitAddContext;
        }

        public static ICommandBuilderContext<GitCloneContext> Clone(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitCloneContext = gitContext
                .Append("clone")
                .ChangeContext<GitCloneContext>()
                ;

            return gitCloneContext;
        }

        public static ICommandBuilderContext<GitCommitContext> Commit(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitCommitContext = gitContext
                .Append("commit")
                .ChangeContext<GitCommitContext>()
                ;

            return gitCommitContext;
        }

        public static ICommandBuilderContext<GitConfigContext> Config(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitConfigContext = gitContext
                .Append("config")
                .ChangeContext<GitConfigContext>()
                ;

            return gitConfigContext;
        }

        public static ICommandBuilderContext<GitPullContext> Fetch(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitPullContext = gitContext
                .Append("fetch")
                .ChangeContext<GitPullContext>()
                ;

            return gitPullContext;
        }

        public static ICommandBuilderContext<GitInitContext> Init(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitInitContext = gitContext
                .Append("init")
                .ChangeContext<GitInitContext>()
                ;
            
            return gitInitContext;
        }

        public static ICommandBuilderContext<GitPullContext> Pull(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitPullContext = gitContext
                .Append("pull")
                .ChangeContext<GitPullContext>()
                ;

            return gitPullContext;
        }

        public static ICommandBuilderContext<GitPushContext> Push(this ICommandBuilderContext<GitContext> gitContext)
        {
            var gitPushContext = gitContext
                .Append("push")
                .ChangeContext<GitPushContext>()
                ;

            return gitPushContext;
        }

        public static ICommandBuilderContext<GitContext> SetCurrentDirectory(this ICommandBuilderContext<GitContext> gitContext, string directoryPath)
        {
            gitContext.AppendNamePathValuePair("-C", directoryPath);

            return gitContext;
        }
    }
}
