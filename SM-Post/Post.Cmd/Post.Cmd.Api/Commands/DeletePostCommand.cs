using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public sealed class DeletePostCommand : BaseCommand
{
    public string Username { get; set; } = default!;
}