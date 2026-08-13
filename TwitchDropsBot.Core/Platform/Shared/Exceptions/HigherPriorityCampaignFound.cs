namespace TwitchDropsBot.Core.Platform.Shared.Exceptions;

[Serializable]
public class HigherPriorityCampaignFound : System.Exception
{
    private const string DefaultMessage = "A new favourite campaign was found, interrupting current watch.";

    public HigherPriorityCampaignFound() : base(DefaultMessage) { }
    public HigherPriorityCampaignFound(string message) : base(message) { }
    public HigherPriorityCampaignFound(string message, System.Exception inner) : base(message, inner) { }
    protected HigherPriorityCampaignFound(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context)
    {
    }
}

