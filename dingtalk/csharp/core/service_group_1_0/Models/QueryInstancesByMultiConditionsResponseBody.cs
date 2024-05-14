// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryInstancesByMultiConditionsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryInstancesByMultiConditionsResponseBodyRecords> Records { get; set; }
        public class QueryInstancesByMultiConditionsResponseBodyRecords : TeaModel {
            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public string Fields { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("modifiedUnionId")]
            [Validation(Required=false)]
            public string ModifiedUnionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openDataInstanceId")]
            [Validation(Required=false)]
            public string OpenDataInstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            [NameInMap("ownerUnionId")]
            [Validation(Required=false)]
            public string OwnerUnionId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
