// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class NlpWordDistinguishRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<string> DeptIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isvAppId")]
        [Validation(Required=false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
