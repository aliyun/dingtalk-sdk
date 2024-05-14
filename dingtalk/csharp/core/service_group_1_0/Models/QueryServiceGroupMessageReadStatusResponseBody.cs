// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryServiceGroupMessageReadStatusResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryServiceGroupMessageReadStatusResponseBodyRecords> Records { get; set; }
        public class QueryServiceGroupMessageReadStatusResponseBodyRecords : TeaModel {
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public int? ReadStatus { get; set; }

            [NameInMap("readTimeStr")]
            [Validation(Required=false)]
            public string ReadTimeStr { get; set; }

            [NameInMap("receiverDingTalkId")]
            [Validation(Required=false)]
            public string ReceiverDingTalkId { get; set; }

            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            [NameInMap("receiverUserId")]
            [Validation(Required=false)]
            public string ReceiverUserId { get; set; }

            [NameInMap("sendTimeStr")]
            [Validation(Required=false)]
            public string SendTimeStr { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
