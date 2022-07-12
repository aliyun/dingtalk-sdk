// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddKnowledgeRequest : TeaModel {
        /// <summary>
        /// 附件列表
        /// </summary>
        [NameInMap("attachmentList")]
        [Validation(Required=false)]
        public List<AddKnowledgeRequestAttachmentList> AttachmentList { get; set; }
        public class AddKnowledgeRequestAttachmentList : TeaModel {
            /// <summary>
            /// 多媒体类型
            /// </summary>
            [NameInMap("mime_type")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            /// <summary>
            /// 附件URL
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// 附件大小
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// 附件扩展名
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// 附件名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 知识点内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public long? EffectTimeend { get; set; }

        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public long? EffectTimestart { get; set; }

        /// <summary>
        /// 知识点扩展问(多个用英文逗号隔开)
        /// </summary>
        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        /// <summary>
        /// 关键字(多个用英文逗号隔开)
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 知识库的唯一标识
        /// </summary>
        [NameInMap("libraryKey")]
        [Validation(Required=false)]
        public string LibraryKey { get; set; }

        /// <summary>
        /// CCM的知识点外链
        /// </summary>
        [NameInMap("linkUrl")]
        [Validation(Required=false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 关联问题id
        /// </summary>
        [NameInMap("questionIds")]
        [Validation(Required=false)]
        public List<long?> QuestionIds { get; set; }

        /// <summary>
        /// 知识点来源
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 知识点唯一标识
        /// </summary>
        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

        /// <summary>
        /// 知识点名称
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 知识点版本号
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
