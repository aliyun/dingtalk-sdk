// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QuerySendMsgTaskStatisticsResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QuerySendMsgTaskStatisticsResponseBodyRecords> Records { get; set; }
        public class QuerySendMsgTaskStatisticsResponseBodyRecords : TeaModel {
            [NameInMap("errorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            [NameInMap("group")]
            [Validation(Required=false)]
            public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup Group { get; set; }
            public class QuerySendMsgTaskStatisticsResponseBodyRecordsGroup : TeaModel {
                [NameInMap("bizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }
                [NameInMap("groupSetName")]
                [Validation(Required=false)]
                public string GroupSetName { get; set; }
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }
                [NameInMap("openGroupSetId")]
                [Validation(Required=false)]
                public string OpenGroupSetId { get; set; }
                [NameInMap("openTeamId")]
                [Validation(Required=false)]
                public string OpenTeamId { get; set; }
            };

            [NameInMap("groupUserReadStatistics")]
            [Validation(Required=false)]
            public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics GroupUserReadStatistics { get; set; }
            public class QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics : TeaModel {
                [NameInMap("openBatchTaskId")]
                [Validation(Required=false)]
                public string OpenBatchTaskId { get; set; }
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }
                [NameInMap("readUserInc")]
                [Validation(Required=false)]
                public long? ReadUserInc { get; set; }
                [NameInMap("sendUserInc")]
                [Validation(Required=false)]
                public long? SendUserInc { get; set; }
                [NameInMap("unReadUserInc")]
                [Validation(Required=false)]
                public long? UnReadUserInc { get; set; }
            };

            [NameInMap("openMsgId")]
            [Validation(Required=false)]
            public string OpenMsgId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
