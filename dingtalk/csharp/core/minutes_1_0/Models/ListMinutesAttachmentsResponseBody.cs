// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class ListMinutesAttachmentsResponseBody : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<ListMinutesAttachmentsResponseBodyAttachments> Attachments { get; set; }
        public class ListMinutesAttachmentsResponseBodyAttachments : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("contentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("noteId")]
            [Validation(Required=false)]
            public long? NoteId { get; set; }

            [NameInMap("noteTime")]
            [Validation(Required=false)]
            public long? NoteTime { get; set; }

            [NameInMap("relativeTimeMs")]
            [Validation(Required=false)]
            public long? RelativeTimeMs { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
