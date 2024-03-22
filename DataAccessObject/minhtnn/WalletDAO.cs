using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class WalletDAO
    {
        public static WalletDAO instance;
        private static object lockObjecy = new object();
        public static WalletDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WalletDAO();
                }
                return instance;
            }
        }

        public bool HaveWallet(int customerId)
        {
            using var db = new HacoloCinemaContext();
            var wallet = db.Wallets.Join(db.Customers, wallet => wallet.CustomerId,
                customer => customer.CustomerId,
                (wallet, customer) => new { Wallet = wallet, Customer = customer })
                .SingleOrDefault(f => f.Customer.CustomerId == customerId);
            return wallet != null;
        }
    }
}
