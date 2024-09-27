// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class UpdatePermissionForUsersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdatePermissionForUsersRequestMembers> Members { get; set; }
        public class UpdatePermissionForUsersRequestMembers : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EDITOR</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>533xxxxxx</para>
        /// </summary>
        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        [NameInMap("operatorUid")]
        [Validation(Required=false)]
        public long? OperatorUid { get; set; }

    }

}
