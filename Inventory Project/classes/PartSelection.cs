using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project.classes
{
    public class InHouse : Part
    {
        public int InHouseMachineId { get; set; }

        public InHouse(int partId, string name, int inStock, decimal price, int min, int max, int machineId)
            : base(partId, name, inStock, price, min, max)
        {
            InHouseMachineId = machineId;
        }

        public override int MachineId()
        {
            return InHouseMachineId;
        }

        public override string CompanyName()
        {
            throw new NotImplementedException();
        }
    }

    public class OutSource : Part
    {
        public string OutSourceCompanyName { get; set; }

        public OutSource(int partId, string name, int inStock, decimal price, int min, int max, string companyName)
            : base(partId, name, inStock, price, min, max)
        {
            OutSourceCompanyName = companyName;
        }

        public override string CompanyName()
        {
            return OutSourceCompanyName;
        }

        public override int MachineId()
        {
            throw new NotImplementedException();
        }
    }
}
