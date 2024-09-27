// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoBatchResponseBody : TeaModel {
        [NameInMap("infos")]
        [Validation(Required=false)]
        public List<QueryConferenceInfoBatchResponseBodyInfos> Infos { get; set; }
        public class QueryConferenceInfoBatchResponseBodyInfos : TeaModel {
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0-正常，1-麦克风静音，2-摄像头关闭，4-强制全员静音</para>
            /// </summary>
            [NameInMap("mediaStatus")]
            [Validation(Required=false)]
            public long? MediaStatus { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0-初始化，1-会议结束，2-会议开始</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<QueryConferenceInfoBatchResponseBodyInfosUserList> UserList { get; set; }
            public class QueryConferenceInfoBatchResponseBodyInfosUserList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0-未定义,1-初始化,2-加入中,3-在会,4-加入失败,5,被踢出,6-离开</para>
                /// </summary>
                [NameInMap("attendStatus")]
                [Validation(Required=false)]
                public long? AttendStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0-初始化，1-关闭，2-打开</para>
                /// </summary>
                [NameInMap("cameraStatus")]
                [Validation(Required=false)]
                public long? CameraStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0-初始化，1-关闭，2-打开</para>
                /// </summary>
                [NameInMap("micStatus")]
                [Validation(Required=false)]
                public long? MicStatus { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>抱歉，正在开会</para>
                /// </summary>
                [NameInMap("rejectDescription")]
                [Validation(Required=false)]
                public string RejectDescription { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
