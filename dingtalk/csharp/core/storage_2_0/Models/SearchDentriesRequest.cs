// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchDentriesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public SearchDentriesRequestOption Option { get; set; }
        public class SearchDentriesRequestOption : TeaModel {
            [NameInMap("createTimeRange")]
            [Validation(Required=false)]
            public SearchDentriesRequestOptionCreateTimeRange CreateTimeRange { get; set; }
            public class SearchDentriesRequestOptionCreateTimeRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>end_time</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>start_time</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("creatorIds")]
            [Validation(Required=false)]
            public List<string> CreatorIds { get; set; }

            [NameInMap("dentryCategories")]
            [Validation(Required=false)]
            public List<string> DentryCategories { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("modifierIds")]
            [Validation(Required=false)]
            public List<string> ModifierIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("spaceIds")]
            [Validation(Required=false)]
            public List<long?> SpaceIds { get; set; }

            [NameInMap("visitTimeRange")]
            [Validation(Required=false)]
            public SearchDentriesRequestOptionVisitTimeRange VisitTimeRange { get; set; }
            public class SearchDentriesRequestOptionVisitTimeRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>end_time</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>start_time</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
