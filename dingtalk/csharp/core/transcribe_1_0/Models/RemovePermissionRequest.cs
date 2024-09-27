// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class RemovePermissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<RemovePermissionRequestMembers> Members { get; set; }
        public class RemovePermissionRequestMembers : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>533xxxxxx</para>
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EDITOR</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
