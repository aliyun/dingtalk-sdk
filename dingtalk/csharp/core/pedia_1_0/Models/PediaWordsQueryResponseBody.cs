// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsQueryResponseBody : TeaModel {
        /// <summary>
        /// 返回词条具体对象
        /// 
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public PediaWordsQueryResponseBodyData Data { get; set; }
        public class PediaWordsQueryResponseBodyData : TeaModel {
            /// <summary>
            /// 相关应用
            /// </summary>
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataAppLink> AppLink { get; set; }
            public class PediaWordsQueryResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// 应用名称
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// 应用icon
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// 桌面端链接
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// 手机端链接
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// 审核人
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            /// <summary>
            /// 联系人列表
            /// </summary>
            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataContactList> ContactList { get; set; }
            public class PediaWordsQueryResponseBodyDataContactList : TeaModel {
                /// <summary>
                /// 联系人图片办好
                /// </summary>
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                /// <summary>
                /// 联系人名称
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// 联系人员工编号
                /// 
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 相关联系人
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// 创建者
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            /// <summary>
            /// 高亮的词条别名
            /// 
            /// </summary>
            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            /// <summary>
            /// 内部群是否高亮
            /// </summary>
            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            /// <summary>
            /// 当为待审核词条的时候的父编号
            /// </summary>
            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public long? ParentUuid { get; set; }

            [NameInMap("picList")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataPicList> PicList { get; set; }
            public class PediaWordsQueryResponseBodyDataPicList : TeaModel {
                /// <summary>
                /// 图片HTTP地址
                /// </summary>
                [NameInMap("mediaIdUrl")]
                [Validation(Required=false)]
                public string MediaIdUrl { get; set; }

            }

            /// <summary>
            /// 相关文档
            /// </summary>
            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class PediaWordsQueryResponseBodyDataRelatedDoc : TeaModel {
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// 文档名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 文档类型，分别为adoc或者asheet
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 相关链接
            /// </summary>
            [NameInMap("relatedLink")]
            [Validation(Required=false)]
            public List<PediaWordsQueryResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class PediaWordsQueryResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// 链接地址
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

            }

            /// <summary>
            /// 服务群是否高亮
            /// </summary>
            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// 词条释义非富文本
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            /// <summary>
            /// 更新人
            /// </summary>
            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            /// <summary>
            /// 操作员工userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 词条主键ID
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
            /// 
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// 词条释义，富文本
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        /// <summary>
        /// 返回结果
        /// false，失败
        /// trur，成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
