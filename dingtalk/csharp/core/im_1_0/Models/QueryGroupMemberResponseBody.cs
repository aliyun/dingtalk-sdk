// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupMembers")]
        [Validation(Required=false)]
        public List<QueryGroupMemberResponseBodyGroupMembers> GroupMembers { get; set; }
        public class QueryGroupMemberResponseBodyGroupMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>http://****.png</para>
            /// </summary>
            [NameInMap("groupMemberAvatar")]
            [Validation(Required=false)]
            public string GroupMemberAvatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>认真工作,快乐生活</para>
            /// </summary>
            [NameInMap("groupMemberDynamics")]
            [Validation(Required=false)]
            public string GroupMemberDynamics { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1107****2120</para>
            /// </summary>
            [NameInMap("groupMemberId")]
            [Validation(Required=false)]
            public string GroupMemberId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Foo</para>
            /// </summary>
            [NameInMap("groupMemberName")]
            [Validation(Required=false)]
            public string GroupMemberName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("groupMemberType")]
            [Validation(Required=false)]
            public int? GroupMemberType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14da****2760</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
