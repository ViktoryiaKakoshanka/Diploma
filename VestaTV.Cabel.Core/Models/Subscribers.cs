﻿using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.Core.Models
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            HistoryOfOrders = new HashSet<HistoryOfOrder>();
            HistoryOfRelationships = new HashSet<HistoryOfRelationship>();
        }

        public int Id { get; set; }
        public int NumberOfContract { get; set; }
        public DateTime ContractDate { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string SecondMobilePhone { get; set; }
        public RelationshipType RelationshipType { get; set; }
        
        public Address Address { get; set; }

        
        public virtual ICollection<HistoryOfOrder> HistoryOfOrders { get; set; }
        public virtual ICollection<HistoryOfRelationship> HistoryOfRelationships { get; set; }
    }
}