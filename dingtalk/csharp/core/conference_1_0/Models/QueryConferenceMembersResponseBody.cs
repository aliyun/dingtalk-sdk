// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceMembersResponseBody : TeaModel {
        /// <summary>
        /// 成员列表
        /// </summary>
        [NameInMap("memberModels")]
        [Validation(Required=false)]
        public List<QueryConferenceMembersResponseBodyMemberModels> MemberModels { get; set; }
        public class QueryConferenceMembersResponseBodyMemberModels : TeaModel {
            /// <summary>
            /// 成员状态 
            /// 1 初始化 
            /// 2 呼叫中
            /// 3 活跃（在会）
            /// 4 入会失败（拒接等）
            /// 5 被踢
            /// 6 离会
            /// </summary>
            [NameInMap("attendStatus")]
            [Validation(Required=false)]
            public int? AttendStatus { get; set; }

            /// <summary>
            /// 是否为联席主持人
            /// </summary>
            [NameInMap("coHost")]
            [Validation(Required=false)]
            public bool? CoHost { get; set; }

            /// <summary>
            /// 会议id
            /// </summary>
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// 在会时长
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 是否为主持人
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public bool? Host { get; set; }

            /// <summary>
            /// 入会时间
            /// </summary>
            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// 离会时间
            /// </summary>
            [NameInMap("leaveTime")]
            [Validation(Required=false)]
            public long? LeaveTime { get; set; }

            /// <summary>
            /// 是否为非会议所属企业内成员
            /// </summary>
            [NameInMap("outerOrgMember")]
            [Validation(Required=false)]
            public bool? OuterOrgMember { get; set; }

            /// <summary>
            /// 是否为pstn入会
            /// </summary>
            [NameInMap("pstnJoin")]
            [Validation(Required=false)]
            public bool? PstnJoin { get; set; }

            /// <summary>
            /// 用户unionId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 成员昵称
            /// </summary>
            [NameInMap("userNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

        /// <summary>
        /// 分页查询下一页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次返回结果数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
