// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchRequest : TeaModel {
        [NameInMap("dentryRequest")]
        [Validation(Required=false)]
        public SearchRequestDentryRequest DentryRequest { get; set; }
        public class SearchRequestDentryRequest : TeaModel {
            [NameInMap("createTimeRange")]
            [Validation(Required=false)]
            public SearchRequestDentryRequestCreateTimeRange CreateTimeRange { get; set; }
            public class SearchRequestDentryRequestCreateTimeRange : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

            }

            [NameInMap("createUsers")]
            [Validation(Required=false)]
            public List<string> CreateUsers { get; set; }

            [NameInMap("editors")]
            [Validation(Required=false)]
            public List<string> Editors { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("searchField")]
            [Validation(Required=false)]
            public int? SearchField { get; set; }

            [NameInMap("searchFileType")]
            [Validation(Required=false)]
            public int? SearchFileType { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("spaceIds")]
            [Validation(Required=false)]
            public List<string> SpaceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("summaryLength")]
            [Validation(Required=false)]
            public int? SummaryLength { get; set; }

            [NameInMap("visitTimeRange")]
            [Validation(Required=false)]
            public SearchRequestDentryRequestVisitTimeRange VisitTimeRange { get; set; }
            public class SearchRequestDentryRequestVisitTimeRange : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试搜索关键词</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("spaceRequest")]
        [Validation(Required=false)]
        public SearchRequestSpaceRequest SpaceRequest { get; set; }
        public class SearchRequestSpaceRequest : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("withTeamInfo")]
            [Validation(Required=false)]
            public bool? WithTeamInfo { get; set; }

        }

    }

}
