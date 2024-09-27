// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListGroupSetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fasfasd</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<ListGroupSetResponseBodyResultList> ResultList { get; set; }
        public class ListGroupSetResponseBodyResultList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-23T13:00Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-23T13:00Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("groupChatCount")]
            [Validation(Required=false)]
            public int? GroupChatCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123agsg</para>
            /// </summary>
            [NameInMap("lastOpenConversationId")]
            [Validation(Required=false)]
            public string LastOpenConversationId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("manager")]
            [Validation(Required=false)]
            public List<ListGroupSetResponseBodyResultListManager> Manager { get; set; }
            public class ListGroupSetResponseBodyResultListManager : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>XX</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>afs1</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>afsd12,afsd13</para>
            /// </summary>
            [NameInMap("managerUserIds")]
            [Validation(Required=false)]
            public string ManagerUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("memberQuota")]
            [Validation(Required=false)]
            public int? MemberQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>营销群</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>群公告</para>
            /// </summary>
            [NameInMap("notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("noticeToped")]
            [Validation(Required=false)]
            public int? NoticeToped { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adfads</para>
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public ListGroupSetResponseBodyResultListOwner Owner { get; set; }
            public class ListGroupSetResponseBodyResultListOwner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>XX</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>afsd12</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>afsd12</para>
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crm_customer_personal</para>
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sfasgsab</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
