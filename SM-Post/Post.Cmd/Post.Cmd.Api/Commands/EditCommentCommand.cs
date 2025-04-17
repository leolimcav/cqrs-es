using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public sealed class EditCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public string Comment { get; set; } = default!;
    public string Username { get; set; } = default!;
}