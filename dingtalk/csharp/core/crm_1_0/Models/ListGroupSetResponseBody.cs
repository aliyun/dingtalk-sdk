// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListGroupSetResponseBody : TeaModel {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一页的游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 群组列表
        /// </summary>
        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<ListGroupSetResponseBodyResultList> ResultList { get; set; }
        public class ListGroupSetResponseBodyResultList : TeaModel {
            /// <summary>
            /// 企业corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 群组内群数量（不包含已解散的群）。
            /// </summary>
            [NameInMap("groupChatCount")]
            [Validation(Required=false)]
            public int? GroupChatCount { get; set; }

            /// <summary>
            /// 最新裂变群的群openConversationId
            /// </summary>
            [NameInMap("lastOpenConversationId")]
            [Validation(Required=false)]
            public string LastOpenConversationId { get; set; }

            /// <summary>
            /// 群管理员列表
            /// </summary>
            [NameInMap("manager")]
            [Validation(Required=false)]
            public List<ListGroupSetResponseBodyResultListManager> Manager { get; set; }
            public class ListGroupSetResponseBodyResultListManager : TeaModel {
                /// <summary>
                /// 群管理员姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 群管理员userId
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 群管理员userId列表，多个用逗号隔开，裂变出的新群会自动设置这些userId为群管理员
            /// </summary>
            [NameInMap("managerUserIds")]
            [Validation(Required=false)]
            public string ManagerUserIds { get; set; }

            /// <summary>
            /// 群组内所有群的成员数量
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// 单个群的人数上限
            /// </summary>
            [NameInMap("memberQuota")]
            [Validation(Required=false)]
            public int? MemberQuota { get; set; }

            /// <summary>
            /// 群组名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 群公告文本，裂变出的新群会自动设置上该群公告
            /// </summary>
            [NameInMap("notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            /// <summary>
            /// 群公告是否置顶，0：不置顶，1：置顶。裂变出的新群会自动设置上该属性
            /// </summary>
            [NameInMap("noticeToped")]
            [Validation(Required=false)]
            public int? NoticeToped { get; set; }

            /// <summary>
            /// 群组openGroupSetId
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// 群主
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
            };

            /// <summary>
            /// 群主userId，裂变出的新群会自动设置该userId为群主
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// 关系类型
            /// </summary>
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// 群模板id
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// 总条数，queryDsl入参为空时才会返回
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
