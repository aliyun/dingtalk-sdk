// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class NlpWordDistinguishRequest : TeaModel {
        [NameInMap("attachExtractDecisionInfo")]
        [Validation(Required=false)]
        public NlpWordDistinguishRequestAttachExtractDecisionInfo AttachExtractDecisionInfo { get; set; }
        public class NlpWordDistinguishRequestAttachExtractDecisionInfo : TeaModel {
            [NameInMap("blackWords")]
            [Validation(Required=false)]
            public List<string> BlackWords { get; set; }

            [NameInMap("candidateWords")]
            [Validation(Required=false)]
            public List<string> CandidateWords { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<string> DeptIds { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("isvAppId")]
        [Validation(Required=false)]
        public string IsvAppId { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
