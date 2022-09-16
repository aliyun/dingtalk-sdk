// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoResponseBody : TeaModel {
        /// <summary>
        /// 会议信息结构体
        /// </summary>
        [NameInMap("confInfo")]
        [Validation(Required=false)]
        public QueryConferenceInfoResponseBodyConfInfo ConfInfo { get; set; }
        public class QueryConferenceInfoResponseBodyConfInfo : TeaModel {
            /// <summary>
            /// 当前在会人数
            /// </summary>
            [NameInMap("activeNum")]
            [Validation(Required=false)]
            public int? ActiveNum { get; set; }

            /// <summary>
            /// 累积入会人数
            /// </summary>
            [NameInMap("attendNum")]
            [Validation(Required=false)]
            public int? AttendNum { get; set; }

            /// <summary>
            /// 会议时长
            /// </summary>
            [NameInMap("confDuration")]
            [Validation(Required=false)]
            public long? ConfDuration { get; set; }

            /// <summary>
            /// 会议id
            /// </summary>
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// 会议创建人unionId
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 会议创建人昵称
            /// </summary>
            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            /// <summary>
            /// 会议结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 会议web入会链接
            /// </summary>
            [NameInMap("externalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

            /// <summary>
            /// 邀请人数
            /// </summary>
            [NameInMap("invitedNum")]
            [Validation(Required=false)]
            public int? InvitedNum { get; set; }

            /// <summary>
            /// 会议码
            /// </summary>
            [NameInMap("roomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            /// <summary>
            /// 会议开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 会议状态
            /// 0 初始化
            /// 1 开始
            /// 2 结束
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 会议标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
