// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryCrmPersonalCustomerResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<QueryCrmPersonalCustomerResponseBodyValues> Values { get; set; }
        public class QueryCrmPersonalCustomerResponseBodyValues : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public QueryCrmPersonalCustomerResponseBodyValuesPermission Permission { get; set; }
            public class QueryCrmPersonalCustomerResponseBodyValuesPermission : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ownerStaffIds")]
                [Validation(Required=false)]
                public List<string> OwnerStaffIds { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("participantStaffIds")]
                [Validation(Required=false)]
                public List<string> ParticipantStaffIds { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("procInstStatus")]
            [Validation(Required=false)]
            public string ProcInstStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("procOutResult")]
            [Validation(Required=false)]
            public string ProcOutResult { get; set; }

        }

    }

}
