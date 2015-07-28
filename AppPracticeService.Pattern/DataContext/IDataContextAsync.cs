﻿using System.Threading;
using System.Threading.Tasks;

namespace AppPracticeService.Pattern.DataContext
{
    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}