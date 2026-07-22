using System;

namespace DBAHawkGUI.Messaging
{
    internal class BrokerResponse
    {
        public string Type { get; set; }
        public byte[] Payload { get; set; }

        public Guid Handle { get; set; }
    }
}
