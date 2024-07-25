// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class ListMailFoldersResponseBody : TeaModel {
        [NameInMap("folders")]
        [Validation(Required=false)]
        public List<ListMailFoldersResponseBodyFolders> Folders { get; set; }
        public class ListMailFoldersResponseBodyFolders : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("childFolderCount")]
            [Validation(Required=false)]
            public int? ChildFolderCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("parentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("totalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unreadItemCount")]
            [Validation(Required=false)]
            public int? UnreadItemCount { get; set; }

        }

    }

}
