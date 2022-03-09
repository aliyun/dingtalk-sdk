// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryObjectiveRequest : TeaModel {
        [NameInMap("objectiveIds")]
        [Validation(Required=false)]
        public List<Stream> ObjectiveIds { get; set; }

        /// <summary>
        /// periodId
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public Stream PeriodId { get; set; }

        /// <summary>
        /// withAlign
        /// </summary>
        [NameInMap("withAlign")]
        [Validation(Required=false)]
        public bool? WithAlign { get; set; }

        /// <summary>
        /// withKr
        /// </summary>
        [NameInMap("withKr")]
        [Validation(Required=false)]
        public bool? WithKr { get; set; }

        /// <summary>
        /// withProgress
        /// </summary>
        [NameInMap("withProgress")]
        [Validation(Required=false)]
        public bool? WithProgress { get; set; }

        /// <summary>
        /// ownerId
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
