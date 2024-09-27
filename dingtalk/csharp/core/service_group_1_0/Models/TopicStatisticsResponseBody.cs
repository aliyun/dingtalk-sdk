// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class TopicStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("topicStatisticsRecords")]
        [Validation(Required=false)]
        public List<TopicStatisticsResponseBodyTopicStatisticsRecords> TopicStatisticsRecords { get; set; }
        public class TopicStatisticsResponseBodyTopicStatisticsRecords : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220101</para>
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("msgCount")]
            [Validation(Required=false)]
            public long? MsgCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("participantsNum")]
            [Validation(Required=false)]
            public long? ParticipantsNum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("topicNum")]
            [Validation(Required=false)]
            public long? TopicNum { get; set; }

        }

    }

}
