// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 返回列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListPunchScheduleByConditionWithPagingResponseBodyList> List { get; set; }
        public class ListPunchScheduleByConditionWithPagingResponseBodyList : TeaModel {
            /// <summary>
            /// 巡点业务id，同个巡点id同一个用户最多会有两条记录，一条签到，一条签退
            /// </summary>
            [NameInMap("bizOuterId")]
            [Validation(Required=false)]
            public string BizOuterId { get; set; }

            /// <summary>
            /// 打卡巡点机名称
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// 巡点类型（checkIn-签到，checkOut-签退）
            /// </summary>
            [NameInMap("punchSymbol")]
            [Validation(Required=false)]
            public string PunchSymbol { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户巡点打卡时间
            /// </summary>
            [NameInMap("userPunchTime")]
            [Validation(Required=false)]
            public long? UserPunchTime { get; set; }

        }

        /// <summary>
        /// 下一次游标位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
