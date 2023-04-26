// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class TopicStatisticsResponseBody : TeaModel {
        [NameInMap("topicStatisticsRecords")]
        [Validation(Required=false)]
        public List<TopicStatisticsResponseBodyTopicStatisticsRecords> TopicStatisticsRecords { get; set; }
        public class TopicStatisticsResponseBodyTopicStatisticsRecords : TeaModel {
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            [NameInMap("msgCount")]
            [Validation(Required=false)]
            public long? MsgCount { get; set; }

            [NameInMap("participantsNum")]
            [Validation(Required=false)]
            public long? ParticipantsNum { get; set; }

            [NameInMap("topicNum")]
            [Validation(Required=false)]
            public long? TopicNum { get; set; }

        }

    }

}
