// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetFamilySchoolConversationsResponseBody : TeaModel {
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GetFamilySchoolConversationsResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GetFamilySchoolConversationsResponseBodyGroupInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp123</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptNameChain")]
            [Validation(Required=false)]
            public List<string> DeptNameChain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小王的家校群</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("joinGroupTime")]
            [Validation(Required=false)]
            public long? JoinGroupTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cidxxx</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1666671122000</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
