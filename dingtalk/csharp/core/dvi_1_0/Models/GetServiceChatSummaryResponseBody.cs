// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetServiceChatSummaryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetServiceChatSummaryResponseBodyResult Result { get; set; }
        public class GetServiceChatSummaryResponseBodyResult : TeaModel {
            [NameInMap("basic")]
            [Validation(Required=false)]
            public List<GetServiceChatSummaryResponseBodyResultBasic> Basic { get; set; }
            public class GetServiceChatSummaryResponseBodyResultBasic : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("product")]
            [Validation(Required=false)]
            public List<GetServiceChatSummaryResponseBodyResultProduct> Product { get; set; }
            public class GetServiceChatSummaryResponseBodyResultProduct : TeaModel {
                [NameInMap("itemList")]
                [Validation(Required=false)]
                public List<GetServiceChatSummaryResponseBodyResultProductItemList> ItemList { get; set; }
                public class GetServiceChatSummaryResponseBodyResultProductItemList : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

        }

    }

}
