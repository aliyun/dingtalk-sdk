// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("includesHolidays")]
        [Validation(Required=false)]
        public bool? IncludesHolidays { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isDuration")]
        [Validation(Required=false)]
        public bool? IsDuration { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("submitterId")]
        [Validation(Required=false)]
        public string SubmitterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workTime")]
        [Validation(Required=false)]
        public long? WorkTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

    }

}
