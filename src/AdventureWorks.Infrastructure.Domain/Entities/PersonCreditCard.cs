﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Infrastructure.Data.EF
{
    public partial class PersonCreditCard
    {
        public int BusinessEntityId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Person BusinessEntity { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
