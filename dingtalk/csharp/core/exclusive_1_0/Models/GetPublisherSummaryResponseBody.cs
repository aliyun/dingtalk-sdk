// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPublisherSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPublisherSummaryResponseBodyData> Data { get; set; }
        public class GetPublisherSummaryResponseBodyData : TeaModel {
            [NameInMap("publisherArticleCntStd")]
            [Validation(Required=false)]
            public string PublisherArticleCntStd { get; set; }

            [NameInMap("publisherArticlePvCntStd")]
            [Validation(Required=false)]
            public string PublisherArticlePvCntStd { get; set; }

            [NameInMap("publisherName")]
            [Validation(Required=false)]
            public string PublisherName { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("publisherArticleCntStd")]
        [Validation(Required=false)]
        public string PublisherArticleCntStd { get; set; }

        [NameInMap("publisherArticlePvCntStd")]
        [Validation(Required=false)]
        public string PublisherArticlePvCntStd { get; set; }

        [NameInMap("publisherArticlePvTop5")]
        [Validation(Required=false)]
        public List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> PublisherArticlePvTop5 { get; set; }
        public class GetPublisherSummaryResponseBodyPublisherArticlePvTop5 : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("publisherCntStd")]
        [Validation(Required=false)]
        public string PublisherCntStd { get; set; }

    }

}
