using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class WalletRepository : IWalletRepository
    {
        public bool HaveWallet(int customerId)
            => WalletDAO.Instance.HaveWallet(customerId);
    }
}
