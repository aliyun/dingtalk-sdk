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
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("publisherArticleCntStd")]
            [Validation(Required=false)]
            public string PublisherArticleCntStd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("publisherArticlePvCntStd")]
            [Validation(Required=false)]
            public string PublisherArticlePvCntStd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>服务窗1</para>
            /// </summary>
            [NameInMap("publisherName")]
            [Validation(Required=false)]
            public string PublisherName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("publisherArticleCntStd")]
        [Validation(Required=false)]
        public string PublisherArticleCntStd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("publisherArticlePvCntStd")]
        [Validation(Required=false)]
        public string PublisherArticlePvCntStd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>阅读量最高文章，阅读量第二高文章</para>
        /// </summary>
        [NameInMap("publisherArticlePvTop5")]
        [Validation(Required=false)]
        public List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> PublisherArticlePvTop5 { get; set; }
        public class GetPublisherSummaryResponseBodyPublisherArticlePvTop5 : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>文章1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("publisherCntStd")]
        [Validation(Required=false)]
        public string PublisherCntStd { get; set; }

    }

}
