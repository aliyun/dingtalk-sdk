// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class ListTemplateResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多模版
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 后续结果的偏移
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 模版信息列表
        /// </summary>
        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<ListTemplateResponseBodyTemplateList> TemplateList { get; set; }
        public class ListTemplateResponseBodyTemplateList : TeaModel {
            /// <summary>
            /// 模版预览url
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// 模版创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 模版对应文档类型
            /// </summary>
            [NameInMap("docType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// 模版Id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 模版类型
            /// </summary>
            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// 模版标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 模版修改时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 模版归属知识库id。
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
