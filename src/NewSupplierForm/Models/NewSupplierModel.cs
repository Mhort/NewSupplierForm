using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSupplierForm.Models
{
    public class NewSupplierModel
    {
        private int ID { get; set; }

        public string CompanyName { get; set; }

        public string MainAddress { get; set; }

        public string AdditionalAddress { get; set; }

        public IEnumerable Contacts { get; set; }

        public string RequestingEntity { get; set; }

        public string RequestReason { get; set; }

        public string SupplierService { get; set; }

        public bool VesselSupplier { get; set; }

        public bool EntitySupplier { get; set; }

        public bool PurachaseMade { get; set; }

        public int IMO { get; set; }

        public int CompanyNo { get; set; }

        public int DOC { get; set; }

        public int VAT { get; set; }

        public string Marcas { get; set; }

        public IEnumerable ISOAccreditations { get; set; }

        public string ParentCompany { get; set; }

        public IEnumerable Subsidiaries { get; set; }

    
    }

    public class Contact
    {
        private int ID { get; set; }

        private string Name { get; set; }

        private string Position { get; set; }

        private string Address { get; set; }

        private string PhoneNumber {get; set;}

    }

}
