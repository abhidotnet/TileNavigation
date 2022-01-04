using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TileNavigation.Models;

namespace TileNavigation.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = 1231, Text = "1231 item", Description="Asset 1231 Details Displayed here.", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="Jacksonville, FL"},
                new Item { Id = 1232, Text = "1232 item", Description="Asset 1232 Details Displayed here", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="California, PA" },
                new Item { Id = 2236, Text = "2236 item", Description="Asset 2236 Details Displayed here", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="Miami, FL" },
                new Item { Id = 2235, Text = "2235 item", Description="Asset 2235 Details Displayed here", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="Paris, TX" },
                new Item { Id = 1234, Text = "1234 item", Description="Asset 1234 Details Displayed here", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="Perris, CA" },
                new Item { Id = 1233, Text = "1233 item", Description="Asset 1233 Details Displayed here", StateSeal="FL;PA;CO", BldgOverHeight=true, BoxSize="12x48", SerialNo="TESTSERIAL001", StorageYard="Jacksonville, FL" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}