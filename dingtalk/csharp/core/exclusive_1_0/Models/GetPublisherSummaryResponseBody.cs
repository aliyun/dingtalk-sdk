// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPublisherSummaryResponseBody : TeaModel {
        /// <summary>
        /// 互动服务窗相关数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPublisherSummaryResponseBodyData> Data { get; set; }
        public class GetPublisherSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// 历史截至当日服务窗文章数
            /// </summary>
            [NameInMap("publisherArticleCntStd")]
            [Validation(Required=false)]
            public string PublisherArticleCntStd { get; set; }

            /// <summary>
            /// 历史截至当日服务窗文章阅读数
            /// </summary>
            [NameInMap("publisherArticlePvCntStd")]
            [Validation(Required=false)]
            public string PublisherArticlePvCntStd { get; set; }

            /// <summary>
            /// 服务窗名称
            /// </summary>
            [NameInMap("publisherName")]
            [Validation(Required=false)]
            public string PublisherName { get; set; }

            /// <summary>
            /// 服务窗unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次请求的分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 历史截至当日服务窗文章数
        /// </summary>
        [NameInMap("publisherArticleCntStd")]
        [Validation(Required=false)]
        public string PublisherArticleCntStd { get; set; }

        /// <summary>
        /// 历史截至当日服务窗文章阅读数
        /// </summary>
        [NameInMap("publisherArticlePvCntStd")]
        [Validation(Required=false)]
        public string PublisherArticlePvCntStd { get; set; }

        /// <summary>
        /// 阅读量最高的5个文章
        /// </summary>
        [NameInMap("publisherArticlePvTop5")]
        [Validation(Required=false)]
        public List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> PublisherArticlePvTop5 { get; set; }
        public class GetPublisherSummaryResponseBodyPublisherArticlePvTop5 : TeaModel {
            /// <summary>
            /// 文章名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 历史截至当日服务窗数
        /// </summary>
        [NameInMap("publisherCntStd")]
        [Validation(Required=false)]
        public string PublisherCntStd { get; set; }

    }

}
