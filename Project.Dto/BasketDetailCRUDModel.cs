﻿using Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dto
{
    public class BasketDetailCRUDModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BmId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public int VatId { get; set; }
        public int UnitId { get; set; }









    }
}