using CQRS.Core.Events;

namespace Post.Common.Events;

public sealed class PostLikedEvent : BaseEvent
{
    public PostLikedEvent() : base(nameof(PostLikedEvent))
    {
    }
}