// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenObjectiveRulePeriodDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("periodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
