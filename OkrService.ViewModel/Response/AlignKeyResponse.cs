﻿using System;
using System.Collections.Generic;

namespace OKRService.ViewModel.Response
{
    public class AlignKeyResponse
    {
        public long GoalKeyId { get; set; }
        public long EmployeeId { get; set; }
        public string KeyDescription { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Score { get; set; }
        public int ImportedType { get; set; }
        public long ImportedId { get; set; }
        public long Source { get; set; }
        public bool IsKeyDisabled { get; set; }

        public int MetricId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal TargetValue { get; set; }
        public int AssignmentTypeId { get; set; }
        public int KrStatusId { get; set; }
        public string CurrencyCode { get; set; }
        public int GoalStatusId { get; set; }
        public decimal ContributorValue { get; set; }
        public List<ContributorsResponse> Contributors { get; set; }
    }
}
