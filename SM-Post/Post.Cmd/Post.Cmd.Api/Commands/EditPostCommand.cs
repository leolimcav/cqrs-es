using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public sealed class EditPostCommand : BaseCommand
{
    public string Message { get; set; } = default!;
}