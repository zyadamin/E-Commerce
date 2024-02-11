using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Manager.Interfaces
{
    public interface IAddressDALManager
    {
        bool Save(Address address);
        bool Edit(Address address);
        bool Delete(long addressId);
        bool Delete(List<long> Ids); 
        List<Address> ListAllAddresses();
        List<Address> ListAddressesByUser();


    }
}
