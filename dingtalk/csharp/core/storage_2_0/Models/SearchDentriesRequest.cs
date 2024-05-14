// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SearchDentriesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
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
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

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

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("modifierIds")]
            [Validation(Required=false)]
            public List<string> ModifierIds { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("visitTimeRange")]
            [Validation(Required=false)]
            public SearchDentriesRequestOptionVisitTimeRange VisitTimeRange { get; set; }
            public class SearchDentriesRequestOptionVisitTimeRange : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
