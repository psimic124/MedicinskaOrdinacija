using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedicinskaOrdinacija {
    public class DataFetcher {
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);
        public async Task<List<Pacijent>> FetchPacijentiAsync() {

           await semaphoreSlim.WaitAsync();
            try {
                using (var context = new OrdinacijaDB()) {
                    return await context.Pacijenti.ToListAsync();
                }
            }
            finally {
                semaphoreSlim.Release();
            }
        }
        public async Task<List<Doktor>> FetchDoktoriAsync() {
            await semaphoreSlim.WaitAsync();
            try {
                using (var context = new OrdinacijaDB()) {
                    return await context.Doktori.ToListAsync();
                }
            }
            finally {
                semaphoreSlim.Release();
            }
        }
    }
}
