// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class BatchInsertSearchItemRequest : TeaModel {
        [NameInMap("searchItemModels")]
        [Validation(Required=false)]
        public List<BatchInsertSearchItemRequestSearchItemModels> SearchItemModels { get; set; }
        public class BatchInsertSearchItemRequestSearchItemModels : TeaModel {
            [NameInMap("footer")]
            [Validation(Required=false)]
            public string Footer { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
