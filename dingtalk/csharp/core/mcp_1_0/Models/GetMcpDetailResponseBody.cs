// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmcp_1_0.Models
{
    public class GetMcpDetailResponseBody : TeaModel {
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<GetMcpDetailResponseBodyCategories> Categories { get; set; }
        public class GetMcpDetailResponseBodyCategories : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

        }

        [NameInMap("charged")]
        [Validation(Required=false)]
        public bool? Charged { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("mcpId")]
        [Validation(Required=false)]
        public string McpId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<GetMcpDetailResponseBodyTools> Tools { get; set; }
        public class GetMcpDetailResponseBodyTools : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputSchema")]
            [Validation(Required=false)]
            public string OutputSchema { get; set; }

        }

    }

}
