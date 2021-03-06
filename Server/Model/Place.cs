﻿using System;
using System.Collections.Generic;

namespace Server.Model
{
    public class Place: IVersioned
    {
        public long Id { get; set; }

        public Restaurant Restaurant { get; set; }

        public string Seats { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public Guid RowVersion { get; set; }
    }
}