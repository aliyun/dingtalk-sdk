// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeApproveResponseBody : TeaModel {
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
        public CreateWorkTimeApproveResponseBodyResult Result { get; set; }
        public class CreateWorkTimeApproveResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>636c9634b183ac0040ee85b4</para>
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
            /// <para>ding123xxx</para>
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
            /// <para>636c9634b183ac0040ee85b4</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

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
