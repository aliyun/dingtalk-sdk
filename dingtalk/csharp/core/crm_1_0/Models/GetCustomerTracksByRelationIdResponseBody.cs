// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCustomerTracksByRelationIdResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("resultList")]
        [Validation(Required=false)]
        public List<GetCustomerTracksByRelationIdResponseBodyResultList> ResultList { get; set; }
        public class GetCustomerTracksByRelationIdResponseBodyResultList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("detail")]
            [Validation(Required=false)]
            public Dictionary<string, string> Detail { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("isvInfo")]
            [Validation(Required=false)]
            public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo IsvInfo { get; set; }
            public class GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo : TeaModel {
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("typeGroup")]
            [Validation(Required=false)]
            public int? TypeGroup { get; set; }

        }

    }

}
