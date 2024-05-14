// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class QueryInterviewsRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("candidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startTimeBeginMillis")]
        [Validation(Required=false)]
        public long? StartTimeBeginMillis { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startTimeEndMillis")]
        [Validation(Required=false)]
        public long? StartTimeEndMillis { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
