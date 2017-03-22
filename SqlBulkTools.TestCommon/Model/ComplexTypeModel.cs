﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlBulkTools.TestCommon.Model
{

    public class ComplexTypeModel
    {

        public EstimatedStats MinEstimate { get; set; }

        public EstimatedStats AverageEstimate { get; set; }

        public double SearchVolume { get; set; }

        public double Competition { get; set; }
    }


    [ComplexType]
    public class EstimatedStats
    {
        public EstimatedStats()
        {
            CreationTime = DateTime.UtcNow;
        }

        public double? AverageCpc { get; set; }

        public double? TotalCost { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
