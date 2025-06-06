using CQRS.Core.Events;

namespace Post.Common.Events;

public sealed class CommentUpdatedEvent : BaseEvent
{
    public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
    {
    }

    public Guid CommentId { get; set; }
    public string Comment { get; set; } = default!;
    public string Username { get; set; } = default!;
    public DateTime EditDate { get; set; }
}