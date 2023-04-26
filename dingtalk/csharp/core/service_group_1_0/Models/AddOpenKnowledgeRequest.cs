// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddOpenKnowledgeRequest : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<AddOpenKnowledgeRequestAttachments> Attachments { get; set; }
        public class AddOpenKnowledgeRequestAttachments : TeaModel {
            [NameInMap("mimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public double? Size { get; set; }

            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public string EffectTimeend { get; set; }

        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public string EffectTimestart { get; set; }

        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public long? LibraryId { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
