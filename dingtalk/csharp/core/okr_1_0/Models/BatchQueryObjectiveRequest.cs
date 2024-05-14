// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryObjectiveRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("objectiveIds")]
        [Validation(Required=false)]
        public List<string> ObjectiveIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        [NameInMap("withAlign")]
        [Validation(Required=false)]
        public bool? WithAlign { get; set; }

        [NameInMap("withKr")]
        [Validation(Required=false)]
        public bool? WithKr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("withProgress")]
        [Validation(Required=false)]
        public bool? WithProgress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
