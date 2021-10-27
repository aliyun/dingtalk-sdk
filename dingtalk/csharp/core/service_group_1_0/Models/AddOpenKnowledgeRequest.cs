// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddOpenKnowledgeRequest : TeaModel {
        /// <summary>
        /// 附件列表
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<AddOpenKnowledgeRequestAttachments> Attachments { get; set; }
        public class AddOpenKnowledgeRequestAttachments : TeaModel {
            /// <summary>
            /// 附件名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 这个是附件URL
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// 附件大小
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public double? Size { get; set; }

            /// <summary>
            /// 附件扩展名
            /// </summary>
            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            /// <summary>
            /// 媒体类型
            /// </summary>
            [NameInMap("mimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

        }

        /// <summary>
        /// 知识点所属类目ID
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// 知识点正文
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 生效结束时间(默认2100-01-01 23:59:59)
        /// </summary>
        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public string EffectTimeend { get; set; }

        /// <summary>
        /// 生效开始时间(默认1980-01-01 00:00:00)
        /// </summary>
        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public string EffectTimestart { get; set; }

        /// <summary>
        /// 扩展问法(多个英文逗号隔开)
        /// </summary>
        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        /// <summary>
        /// 关键词(多个逗号隔开)
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 所属知识库唯一标识id
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public long? LibraryId { get; set; }

        /// <summary>
        /// 所属团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 知识点来源
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 标签(多个可逗号隔开)
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// 知识点标准问
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 知识点类型()
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户昵称或姓名
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
