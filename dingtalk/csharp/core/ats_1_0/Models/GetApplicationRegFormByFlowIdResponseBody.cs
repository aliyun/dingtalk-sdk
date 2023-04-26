// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetApplicationRegFormByFlowIdResponseBody : TeaModel {
        [NameInMap("candidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("formId")]
        [Validation(Required=false)]
        public string FormId { get; set; }

        [NameInMap("gmtCreateMillis")]
        [Validation(Required=false)]
        public long? GmtCreateMillis { get; set; }

        [NameInMap("gmtModifiedMillis")]
        [Validation(Required=false)]
        public long? GmtModifiedMillis { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

    }

}
