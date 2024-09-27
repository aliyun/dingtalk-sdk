// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateWorkTimeApproveResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>执行成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateWorkTimeApproveResponseBodyResult Result { get; set; }
        public class UpdateWorkTimeApproveResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6446626a9fb5a70c05fc3fc3</para>
            /// </summary>
            [NameInMap("approveOpenId")]
            [Validation(Required=false)]
            public string ApproveOpenId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6446626a9fb5a70c05fc3fc3</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-04T00:00:00.000Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingxxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-04T00:00:00.000Z</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6446626a9fb5a70c05fc3fc3</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx用工申请</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxbpms.xxx/xxxx">https://xxxbpms.xxx/xxxx</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6446626a9fb5a70c05fc3fc3</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workTimeIds")]
            [Validation(Required=false)]
            public List<string> WorkTimeIds { get; set; }

        }

    }

}
