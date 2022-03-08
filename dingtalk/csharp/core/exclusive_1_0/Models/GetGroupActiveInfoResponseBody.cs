// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupActiveInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGroupActiveInfoResponseBodyData> Data { get; set; }
        public class GetGroupActiveInfoResponseBodyData : TeaModel {
            /// <summary>
            /// 群组id
            /// </summary>
            [NameInMap("dingGroupId")]
            [Validation(Required=false)]
            public string DingGroupId { get; set; }

            /// <summary>
            /// 群组创建时间
            /// </summary>
            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public string GroupCreateTime { get; set; }

            /// <summary>
            /// 群组创建用户id
            /// </summary>
            [NameInMap("groupCreateUserId")]
            [Validation(Required=false)]
            public string GroupCreateUserId { get; set; }

            /// <summary>
            /// 群组创建用户姓名
            /// </summary>
            [NameInMap("groupCreateUserName")]
            [Validation(Required=false)]
            public string GroupCreateUserName { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public long? GroupType { get; set; }

            /// <summary>
            /// 最近1天群人数
            /// </summary>
            [NameInMap("groupUserCnt1d")]
            [Validation(Required=false)]
            public int? GroupUserCnt1d { get; set; }

            /// <summary>
            /// 最近1天打开群人数
            /// </summary>
            [NameInMap("openConvUv1d")]
            [Validation(Required=false)]
            public int? OpenConvUv1d { get; set; }

            /// <summary>
            /// 最近1天发消息次数
            /// </summary>
            [NameInMap("sendMessageCnt1d")]
            [Validation(Required=false)]
            public long? SendMessageCnt1d { get; set; }

            /// <summary>
            /// 最近1天发消息人数
            /// </summary>
            [NameInMap("sendMessageUserCnt1d")]
            [Validation(Required=false)]
            public long? SendMessageUserCnt1d { get; set; }

            /// <summary>
            /// 统计时间
            /// </summary>
            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
