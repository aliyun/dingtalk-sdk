// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class TopicStatisticsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("topicStatisticsRecords")]
        [Validation(Required=false)]
        public List<TopicStatisticsResponseBodyTopicStatisticsRecords> TopicStatisticsRecords { get; set; }
        public class TopicStatisticsResponseBodyTopicStatisticsRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("msgCount")]
            [Validation(Required=false)]
            public long? MsgCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("participantsNum")]
            [Validation(Required=false)]
            public long? ParticipantsNum { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("topicNum")]
            [Validation(Required=false)]
            public long? TopicNum { get; set; }

        }

    }

}
