// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListGroupSetResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<ListGroupSetResponseBodyResultList> ResultList { get; set; }
        public class ListGroupSetResponseBodyResultList : TeaModel {
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("groupChatCount")]
            [Validation(Required=false)]
            public int? GroupChatCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("lastOpenConversationId")]
            [Validation(Required=false)]
            public string LastOpenConversationId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("manager")]
            [Validation(Required=false)]
            public List<ListGroupSetResponseBodyResultListManager> Manager { get; set; }
            public class ListGroupSetResponseBodyResultListManager : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("managerUserIds")]
            [Validation(Required=false)]
            public string ManagerUserIds { get; set; }

            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            [NameInMap("memberQuota")]
            [Validation(Required=false)]
            public int? MemberQuota { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            [NameInMap("noticeToped")]
            [Validation(Required=false)]
            public int? NoticeToped { get; set; }

            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public ListGroupSetResponseBodyResultListOwner Owner { get; set; }
            public class ListGroupSetResponseBodyResultListOwner : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
