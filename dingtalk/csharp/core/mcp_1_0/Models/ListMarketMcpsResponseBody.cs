// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmcp_1_0.Models
{
    public class ListMarketMcpsResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListMarketMcpsResponseBodyItems> Items { get; set; }
        public class ListMarketMcpsResponseBodyItems : TeaModel {
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<ListMarketMcpsResponseBodyItemsCategories> Categories { get; set; }
            public class ListMarketMcpsResponseBodyItemsCategories : TeaModel {
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

            [NameInMap("mcpId")]
            [Validation(Required=false)]
            public string McpId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
