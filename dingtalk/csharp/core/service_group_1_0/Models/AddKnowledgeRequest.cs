// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddKnowledgeRequest : TeaModel {
        [NameInMap("attachmentList")]
        [Validation(Required=false)]
        public List<AddKnowledgeRequestAttachmentList> AttachmentList { get; set; }
        public class AddKnowledgeRequestAttachmentList : TeaModel {
            [NameInMap("mime_type")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("effectTimeend")]
        [Validation(Required=false)]
        public long? EffectTimeend { get; set; }

        [NameInMap("effectTimestart")]
        [Validation(Required=false)]
        public long? EffectTimestart { get; set; }

        [NameInMap("extTitle")]
        [Validation(Required=false)]
        public string ExtTitle { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("libraryKey")]
        [Validation(Required=false)]
        public string LibraryKey { get; set; }

        [NameInMap("linkUrl")]
        [Validation(Required=false)]
        public string LinkUrl { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("questionIds")]
        [Validation(Required=false)]
        public List<long?> QuestionIds { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
