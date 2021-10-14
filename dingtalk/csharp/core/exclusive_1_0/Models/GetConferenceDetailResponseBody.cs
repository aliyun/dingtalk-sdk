// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetConferenceDetailResponseBody : TeaModel {
        /// <summary>
        /// 出席会议人数
        /// </summary>
        [NameInMap("attendeeNum")]
        [Validation(Required=false)]
        public long? AttendeeNum { get; set; }

        /// <summary>
        /// 出席率
        /// </summary>
        [NameInMap("attendeePercentage")]
        [Validation(Required=false)]
        public string AttendeePercentage { get; set; }

        /// <summary>
        /// 发起人uid
        /// </summary>
        [NameInMap("callerId")]
        [Validation(Required=false)]
        public string CallerId { get; set; }

        /// <summary>
        /// 发起人昵称
        /// </summary>
        [NameInMap("callerName")]
        [Validation(Required=false)]
        public string CallerName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("confStartTime")]
        [Validation(Required=false)]
        public float? ConfStartTime { get; set; }

        /// <summary>
        /// 会议ID
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        /// <summary>
        /// 参会人员列表
        /// </summary>
        [NameInMap("memberList")]
        [Validation(Required=false)]
        public List<GetConferenceDetailResponseBodyMemberList> MemberList { get; set; }
        public class GetConferenceDetailResponseBodyMemberList : TeaModel {
            /// <summary>
            /// 用户uid
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 用户昵称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 参会时长
            /// </summary>
            [NameInMap("attendDuration")]
            [Validation(Required=false)]
            public float? AttendDuration { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

        }

        /// <summary>
        /// 会议标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 会议人数
        /// </summary>
        [NameInMap("totalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
