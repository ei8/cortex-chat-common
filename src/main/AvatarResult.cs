using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Chat.Common
{
    public class AvatarResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ExternalReferenceUrl { get; set; }
        public string Url { get; set; }
    }
}
