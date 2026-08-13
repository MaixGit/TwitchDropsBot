using TwitchDropsBot.Core.Platform.Shared.WatchManager;

namespace TwitchDropsBot.Core.Platform.Twitch.Settings;

public class TwitchSettings
{
    public List<TwitchUserSettings> TwitchUsers { get; set; } = new List<TwitchUserSettings>();
    public List<string> AvoidCampaign { get; set; } = new List<string>();
    public bool OnlyFavouriteGames { get; set; } = false;
    public bool MinimizeInTray { get; set; } = true;
    public bool ForceTryWithTags { get; set; } = false;
    public bool OnlyConnectedAccounts { get; set; } = false;
    public string WatchManager { get; set; } = WatchManagerType.WatchRequest;

    /// <summary>
    /// When true (default), the bot automatically claims completed drops and reward
    /// codes. Set to false to leave completed drops unclaimed so you can claim them
    /// manually instead.
    /// </summary>
    public bool AutoClaimDrops { get; set; } = true;

    /// When true, the bot will periodically check for newly available favourite-game
    /// campaigns while it is actively watching a non-favourite campaign, and switch to
    /// them instead of finishing the current (potentially long) drop first.
    /// </summary>
    public bool PreemptForFavourites { get; set; } = true;

    /// <summary>
    /// How often (in minutes) the bot checks for a new favourite-game campaign while
    /// watching a non-favourite one. Only used when PreemptForFavourites is true.
    /// </summary>
    public int PreemptCheckIntervalMinutes { get; set; } = 5;
}