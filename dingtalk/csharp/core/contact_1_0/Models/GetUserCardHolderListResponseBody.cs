// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetUserCardHolderListResponseBody : TeaModel {
        /// <summary>
        /// 是否还有数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 名片夹列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<GetUserCardHolderListResponseBodyList> List { get; set; }
        public class GetUserCardHolderListResponseBodyList : TeaModel {
            /// <summary>
            /// 头像
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// 名片收下状态
            /// </summary>
            [NameInMap("cardAcceptStatus")]
            [Validation(Required=false)]
            public int? CardAcceptStatus { get; set; }

            [NameInMap("cardAcceptTime")]
            [Validation(Required=false)]
            public object CardAcceptTime { get; set; }

            /// <summary>
            /// 名片ID
            /// </summary>
            [NameInMap("cardId")]
            [Validation(Required=false)]
            public string CardId { get; set; }

            /// <summary>
            /// 扩展信息
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extension { get; set; }

            /// <summary>
            /// 行业名称
            /// </summary>
            [NameInMap("industryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// 个人介绍
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// 名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 组织名称
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 模板ID
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// 职位
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
