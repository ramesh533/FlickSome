﻿using FlickMeter.Infrastructure;
using FlickMeter.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickMeter.Data.Entities
{
    public class MovieReview : IObjectState
    {
        public int Id { get; set; }
        public virtual DateTime ReviewedDate { get; set; }
        public int Rating { get; set; }
        public string TagLine { get; set; }
        public string Review { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Reviewer Reviewer { get; set; }

        public ObjectState State { get; set; }
    }
}
