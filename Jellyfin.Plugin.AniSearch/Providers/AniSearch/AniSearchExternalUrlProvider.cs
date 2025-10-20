using System.Collections.Generic;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace Jellyfin.Plugin.AniSearch.Providers.AniSearch;

/// <summary>
/// External url provider for AniSearch.
/// </summary>
public class AniSearchExternalUrlProvider : IExternalUrlProvider
{
    public string Name { get; }

    public IEnumerable<string> GetExternalUrls(BaseItem item)
    {
        if (item.TryGetProviderId(ProviderNames.AniSearch, out var externalId))
        {
            switch (item)
            {
                case Series:
                    yield return $"https://www.anisearch.com/anime/{externalId}";
                    yield break;
            }
        }
    }
}
