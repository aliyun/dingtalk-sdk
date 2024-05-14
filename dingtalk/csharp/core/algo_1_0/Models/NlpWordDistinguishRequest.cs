// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class NlpWordDistinguishRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<string> DeptIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isvAppId")]
        [Validation(Required=false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
