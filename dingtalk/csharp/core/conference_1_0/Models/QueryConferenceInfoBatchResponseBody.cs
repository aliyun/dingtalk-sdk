// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoBatchResponseBody : TeaModel {
        /// <summary>
        /// 会议详情列表
        /// </summary>
        [NameInMap("infos")]
        [Validation(Required=false)]
        public List<QueryConferenceInfoBatchResponseBodyInfos> Infos { get; set; }
        public class QueryConferenceInfoBatchResponseBodyInfos : TeaModel {
            /// <summary>
            /// 会议iD
            /// </summary>
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// 媒体状态
            /// </summary>
            [NameInMap("mediaStatus")]
            [Validation(Required=false)]
            public long? MediaStatus { get; set; }

            /// <summary>
            /// 会议开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 会议状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 会议名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 参会用户列表
            /// </summary>
            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<QueryConferenceInfoBatchResponseBodyInfosUserList> UserList { get; set; }
            public class QueryConferenceInfoBatchResponseBodyInfosUserList : TeaModel {
                /// <summary>
                /// 在会状态
                /// </summary>
                [NameInMap("attendStatus")]
                [Validation(Required=false)]
                public long? AttendStatus { get; set; }

                /// <summary>
                /// 摄像头状态
                /// </summary>
                [NameInMap("cameraStatus")]
                [Validation(Required=false)]
                public long? CameraStatus { get; set; }

                /// <summary>
                /// 麦克风状态
                /// </summary>
                [NameInMap("micStatus")]
                [Validation(Required=false)]
                public long? MicStatus { get; set; }

                /// <summary>
                /// 名称
                /// </summary>
                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// 拒绝原因
                /// </summary>
                [NameInMap("rejectDescription")]
                [Validation(Required=false)]
                public string RejectDescription { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
