using System;

namespace ei8.Cortex.Chat.Common
{
    public class MessageResult
    {
        public Guid Id { get; set; }

        public Guid ContentId { get; set; }

        public string ContentString { get; set; }

        public string SenderTag { get; set; }

        public Guid SenderId { get; set; }

        public string RegionTag { get; set; }

        public Guid? RegionId { get; set; }

        public string ExternalReferenceUrl { get; set; }

        public DateTimeOffset? CreationTimestamp { get; set; }

        public DateTimeOffset? UnifiedLastModificationTimestamp { get; set; }

        public bool IsCurrentUserCreationAuthor { get; set; }
    }
}
