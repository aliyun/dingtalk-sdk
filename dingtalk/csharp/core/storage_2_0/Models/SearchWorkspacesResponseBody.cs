// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchWorkspacesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchWorkspacesResponseBodyItems> Items { get; set; }
        public class SearchWorkspacesResponseBodyItems : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
