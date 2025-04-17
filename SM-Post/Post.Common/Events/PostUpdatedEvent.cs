using CQRS.Core.Events;

namespace Post.Common.Events;

public sealed class PostUpdatedEvent : BaseEvent
{
    public PostUpdatedEvent() : base(nameof(PostUpdatedEvent))
    {
    }

    public string Message { get; set; } = default!;
}