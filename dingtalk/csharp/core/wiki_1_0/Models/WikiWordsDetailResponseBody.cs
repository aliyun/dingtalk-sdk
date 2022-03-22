// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsDetailResponseBody : TeaModel {
        /// <summary>
        /// 返回的参数
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsDetailResponseBodyData> Data { get; set; }
        public class WikiWordsDetailResponseBodyData : TeaModel {
            /// <summary>
            /// 应用对象
            /// </summary>
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataAppLink> AppLink { get; set; }
            public class WikiWordsDetailResponseBodyDataAppLink : TeaModel {
                /// <summary>
                /// 应用编号
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// 应用名称
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// 应用图片链接
                /// </summary>
                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                /// <summary>
                /// 应用PC端链接
                /// </summary>
                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                /// <summary>
                /// 应用手机端链接
                /// </summary>
                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            /// <summary>
            /// 审批人
            /// </summary>
            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            /// <summary>
            /// 联系人
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// 创建人
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
            /// 组织名称
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 相关文档
            /// </summary>
            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedDoc : TeaModel {
                /// <summary>
                /// 链接
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                /// <summary>
                /// 名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 文档类型doc或者sheet
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
            public List<WikiWordsDetailResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedLink : TeaModel {
                /// <summary>
                /// 链接
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
                /// 链接类型
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// 服务群是否高亮
            /// </summary>
            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            /// <summary>
            /// 抹除文本格式后的释义
            /// </summary>
            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            /// <summary>
            /// 标签列表
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
            /// 唯一编号
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            /// <summary>
            /// 别名
            /// </summary>
            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            /// <summary>
            /// 全名
            /// </summary>
            [NameInMap("wordFullName")]
            [Validation(Required=false)]
            public string WordFullName { get; set; }

            /// <summary>
            /// 词条名称
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            /// <summary>
            /// 原始释义(带格式数据的释义）
            /// </summary>
            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        /// <summary>
        /// 返回的错误信息
        /// </summary>
        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
