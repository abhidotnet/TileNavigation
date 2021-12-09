using System.Collections.Generic;
using System.Linq;
using TileNavigation.ViewModels;

namespace TileNavigation.Services
{
    public static class DataService
    {
        public static List<Asset> assets { get; } = new List<Asset>
        {
            new Asset(){AssetClass="SNGL1020",AssetId=1231,Location="Denver, CO",SerialNumber ="BRILL001"},
            new Asset(){AssetClass="SNGL1024",AssetId=1232,Location="Philadelphia, PA",SerialNumber ="KIRL012"},
            new Asset(){AssetClass="SNGL1024",AssetId=1233,Location="Philadelphia, PA",SerialNumber ="SN-01230"},
            new Asset(){AssetClass="SNGL1024",AssetId=1234,Location="Exton, PA",SerialNumber ="SN-12301"},
            new Asset(){AssetClass="SNGL1024",AssetId=1235,Location="San Francisco, CA",SerialNumber ="SN-12302"},
            new Asset(){AssetClass="SNGL1024",AssetId=2235,Location="Phoenix, AZ",SerialNumber ="SNR1201"},
            new Asset(){AssetClass="SNGL1224",AssetId=2236,Location="Phoenix, AZ",SerialNumber ="AS01-1230"}
        };

        public static List<Asset> GetSearchResults(string queryString)
        {
            return assets.Where(a => a.Location.ToLowerInvariant().Contains(queryString.ToLowerInvariant())).ToList();
        }

    }
}
