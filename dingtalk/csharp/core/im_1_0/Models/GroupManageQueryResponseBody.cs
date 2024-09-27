// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryResponseBody : TeaModel {
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GroupManageQueryResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GroupManageQueryResponseBodyGroupInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("banWordsMode")]
            [Validation(Required=false)]
            public int? BanWordsMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1652183395772</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            [NameInMap("groupAdminList")]
            [Validation(Required=false)]
            public List<string> GroupAdminList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>574892167781263748</para>
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>今天吃肘子群</para>
            /// </summary>
            [NameInMap("groupTitle")]
            [Validation(Required=false)]
            public string GroupTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cidnvcxzklxv23jhkg412hj==</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INNER</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
