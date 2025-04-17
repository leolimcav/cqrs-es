using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public sealed class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public string Username { get; set; } = default!;
}