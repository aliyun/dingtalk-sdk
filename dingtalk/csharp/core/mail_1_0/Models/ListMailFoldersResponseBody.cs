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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("childFolderCount")]
            [Validation(Required=false)]
            public int? ChildFolderCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("parentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("totalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unreadItemCount")]
            [Validation(Required=false)]
            public int? UnreadItemCount { get; set; }

        }

    }

}
