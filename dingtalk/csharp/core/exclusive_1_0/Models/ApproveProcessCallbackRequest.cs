// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ApproveProcessCallbackRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("request")]
        [Validation(Required=false)]
        public ApproveProcessCallbackRequestRequest Request { get; set; }
        public class ApproveProcessCallbackRequestRequest : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("approveResult")]
            [Validation(Required=false)]
            public string ApproveResult { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("approveType")]
            [Validation(Required=false)]
            public string ApproveType { get; set; }

            [NameInMap("approvers")]
            [Validation(Required=false)]
            public List<string> Approvers { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            [NameInMap("params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
