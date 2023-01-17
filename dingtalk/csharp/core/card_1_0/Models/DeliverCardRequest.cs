// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class DeliverCardRequest : TeaModel {
        /// <summary>
        /// 协作投放参数
        /// </summary>
        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class DeliverCardRequestCoFeedOpenDeliverModel : TeaModel {
            /// <summary>
            /// 【必填】业务标识
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// 【必填】协作场域下的排序时间
            /// </summary>
            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        /// <summary>
        /// 群聊投放参数
        /// </summary>
        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class DeliverCardRequestImGroupOpenDeliverModel : TeaModel {
            /// <summary>
            /// 消息@人，
            /// </summary>
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            /// <summary>
            /// 指定接收者
            /// </summary>
            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

            /// <summary>
            /// 机器人的code
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        /// <summary>
        /// 单聊机器人场域投放参数
        /// 
        /// 【注意】 机器人与人的单聊，直接用支持机器人单聊的应用来发送
        /// </summary>
        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class DeliverCardRequestImRobotOpenDeliverModel : TeaModel {
            /// <summary>
            /// 【条件必填】IM机器人单聊暂无其他投放属性，仅需设置spaeType为IM_ROBOT
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// dt.card//spaceType.spaceId;spaceType.spaceId
        /// </summary>
        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        /// <summary>
        /// 外部卡片实例Id
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 吊顶投放参数
        /// </summary>
        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class DeliverCardRequestTopOpenDeliverModel : TeaModel {
            /// <summary>
            /// 【必填】过期时间戳
            /// </summary>
            [NameInMap("expiredTimeMillis")]
            [Validation(Required=false)]
            public long? ExpiredTimeMillis { get; set; }

            /// <summary>
            /// 可以查看该吊顶卡片的设备
            /// </summary>
            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            /// <summary>
            /// 可以查看该吊顶卡片的staffId
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// 用户id类型：
        /// 
        /// 1（默认）：userid模式
        /// 
        /// 2：unionId模式
        /// </summary>
        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
