using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public sealed class AddCommentCommand : BaseCommand
{
    public string Comment { get; set; } = default!;
    public string Username { get; set; } = default!;
}