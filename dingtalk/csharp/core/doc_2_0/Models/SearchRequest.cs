// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchRequest : TeaModel {
        /// <summary>
        /// 节点搜索请求，和空间搜索请求二选一必填。
        /// </summary>
        [NameInMap("dentryRequest")]
        [Validation(Required=false)]
        public SearchRequestDentryRequest DentryRequest { get; set; }
        public class SearchRequestDentryRequest : TeaModel {
            /// <summary>
            /// 每页最大条目数，最大值50。
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 搜索的字段。支持的有：1-标题和内容；2-标题、内容和评论；3-标题和评论；4-标题；5-内容；6-评论。
            /// </summary>
            [NameInMap("searchField")]
            [Validation(Required=false)]
            public int? SearchField { get; set; }

            /// <summary>
            /// 搜索指定的文件类型。支持的类型有：1-文档；2-表格；3-脑图；4-演示；5-白板。
            /// </summary>
            [NameInMap("searchFileType")]
            [Validation(Required=false)]
            public int? SearchFileType { get; set; }

            /// <summary>
            /// 知识库id，在指定的知识库中搜索。
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// 文档内容命中了搜索关键词的时候，需要返回的文档摘要长度。
            /// </summary>
            [NameInMap("summaryLength")]
            [Validation(Required=false)]
            public int? SummaryLength { get; set; }

            /// <summary>
            /// 文档访问时间的范围。
            /// </summary>
            [NameInMap("visitTimeRange")]
            [Validation(Required=false)]
            public SearchRequestDentryRequestVisitTimeRange VisitTimeRange { get; set; }
            public class SearchRequestDentryRequestVisitTimeRange : TeaModel {
                /// <summary>
                /// 结束时间戳（ms）。
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// 起始时间戳（ms）。
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

            }

        }

        /// <summary>
        ///  搜索关键词。
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 操作人unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 空间搜索请求，和节点搜索请求二选一必填。
        /// </summary>
        [NameInMap("spaceRequest")]
        [Validation(Required=false)]
        public SearchRequestSpaceRequest SpaceRequest { get; set; }
        public class SearchRequestSpaceRequest : TeaModel {
            /// <summary>
            /// 每页最大条目数，最大值50。
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
