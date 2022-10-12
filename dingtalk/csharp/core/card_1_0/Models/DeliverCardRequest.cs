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
        /// 单聊场域投放参数
        /// </summary>
        [NameInMap("imSingleOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestImSingleOpenDeliverModel ImSingleOpenDeliverModel { get; set; }
        public class DeliverCardRequestImSingleOpenDeliverModel : TeaModel {
            /// <summary>
            /// 消息@人，
            /// </summary>
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

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
            [NameInMap("expiredTimeMills")]
            [Validation(Required=false)]
            public long? ExpiredTimeMills { get; set; }

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
        /// 工作台投放参数
        /// </summary>
        [NameInMap("workBenchOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardRequestWorkBenchOpenDeliverModel WorkBenchOpenDeliverModel { get; set; }
        public class DeliverCardRequestWorkBenchOpenDeliverModel : TeaModel {
            /// <summary>
            /// 【必填】组件icon对应组件左上角的图标
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 【必填】卡片名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 【必填】卡片组件名
            /// </summary>
            [NameInMap("pluginComponentName")]
            [Validation(Required=false)]
            public string PluginComponentName { get; set; }

            /// <summary>
            /// 【必填】卡片预览图
            /// </summary>
            [NameInMap("previewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// 【必填】保持和微应用名称相同
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// 【必填】操作者Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
