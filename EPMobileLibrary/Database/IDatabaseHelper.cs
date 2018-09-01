using System;
using System.Threading.Tasks;

namespace EPMobileLibrary.Database
{
    public interface IDatabaseHelper
    {
     
        Task AddOrUpdateUserAsync(User user);

    }
}
