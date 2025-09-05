// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetFlowByIdResponseBody : TeaModel {
        [NameInMap("candidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        [NameInMap("candidateName")]
        [Validation(Required=false)]
        public string CandidateName { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("currentStatus")]
        [Validation(Required=false)]
        public string CurrentStatus { get; set; }

        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("sourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        [NameInMap("statId")]
        [Validation(Required=false)]
        public string StatId { get; set; }

    }

}
