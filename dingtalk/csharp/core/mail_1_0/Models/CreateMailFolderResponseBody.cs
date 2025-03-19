// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class CreateMailFolderResponseBody : TeaModel {
        [NameInMap("folder")]
        [Validation(Required=false)]
        public CreateMailFolderResponseBodyFolder Folder { get; set; }
        public class CreateMailFolderResponseBodyFolder : TeaModel {
            [NameInMap("childFolderCount")]
            [Validation(Required=false)]
            public int? ChildFolderCount { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("extensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extensions { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("parentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

            [NameInMap("totalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            [NameInMap("unreadItemCount")]
            [Validation(Required=false)]
            public int? UnreadItemCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
