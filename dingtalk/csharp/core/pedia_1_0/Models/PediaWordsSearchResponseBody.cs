// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsSearchResponseBody : TeaModel {
        /// <summary>
        /// 词条详情对象
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PediaWordsSearchResponseBodyData> Data { get; set; }
        public class PediaWordsSearchResponseBodyData : TeaModel {
            /// <summary>
            /// 相关应用列表
            /// </summary>
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataAppLink> AppLink { get; set; }
            public class PediaWordsSearchResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// 应用名称
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// 应用图标
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// PC端链接地址
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// 手机端地址
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// 审核者名称
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            /// <summary>
            /// 相关联系人
            /// </summary>
            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataContactList> ContactList { get; set; }
            public class PediaWordsSearchResponseBodyDataContactList : TeaModel {
                /// <summary>
                /// 员工头像
                /// </summary>
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                /// <summary>
                /// 员工的名字
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// 员工的userId
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 联系人列表
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// 创建者的名称
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 词条创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 词条修改时间
            /// </summary>
            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            /// <summary>
            /// 词条中需要在聊天中被分词的别名
            /// </summary>
            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            /// <summary>
            /// 该词条内部群是否分词
            /// </summary>
            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            /// <summary>
            /// 当前词条的父类ID，审核通过的该字段为空
            /// </summary>
            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public long? ParentUuid { get; set; }

            /// <summary>
            /// 相关图片
            /// </summary>
            [NameInMap("picList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataPicList> PicList { get; set; }
            public class PediaWordsSearchResponseBodyDataPicList : TeaModel {
                /// <summary>
                /// 相关图片地址
                /// </summary>
                [NameInMap("mediaIdUrl")]
                [Validation(Required=false)]
                public string MediaIdUrl { get; set; }

            }

            /// <summary>
            /// 相关文档链接，这里只针对钉钉在线文档，没有则忽略
            /// </summary>
            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// 当前在线文档链接地址
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// 在线文档的名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 在线文档的类型，分别为adoc和asheet两个值获取文档图标
                /// 
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 相关链接
            /// 
            /// </summary>
            [NameInMap("relatedLink")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// 具体链接
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// 链接名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 空
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 该词条服务群是否分词
            /// </summary>
            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// 词条非富文本释义
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            /// <summary>
            /// 分类列表
            /// </summary>
            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// 更新者名称
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// 员工的userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 当前词条对应的主键ID
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            /// <summary>
            /// 词条别名
            /// </summary>
            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// 词条名称
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// 词条富文本释义
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
