// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class UpdatePermissionForUsersRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdatePermissionForUsersRequestMembers> Members { get; set; }
        public class UpdatePermissionForUsersRequestMembers : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public long? OperatorUid { get; set; }

    }

}
