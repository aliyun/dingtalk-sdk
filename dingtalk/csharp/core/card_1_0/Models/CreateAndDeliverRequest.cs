// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverRequest : TeaModel {
        /// <summary>
        /// 卡片回调时的路由 key
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// 卡片数据
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCardData CardData { get; set; }
        public class CreateAndDeliverRequestCardData : TeaModel {
            /// <summary>
            /// 卡片模板-文本内容参数
            /// </summary>
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// 卡片内容模板ID
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 协作投放参数
        /// </summary>
        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenDeliverModel : TeaModel {
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
        /// 协作场域信息
        /// </summary>
        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenSpaceModel : TeaModel {
            [NameInMap("coolAppCode")]
            [Validation(Required=false)]
            public string CoolAppCode { get; set; }

            /// <summary>
            /// 【必填】标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 文档投放参数
        /// </summary>
        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestDocOpenDeliverModel : TeaModel {
            /// <summary>
            /// 【必填】员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 群聊投放参数
        /// </summary>
        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImGroupOpenDeliverModel : TeaModel {
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
        /// IM群聊场域信息
        /// </summary>
        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestImGroupOpenSpaceModel : TeaModel {
            /// <summary>
            /// 支持国际化的LastMessage
            /// </summary>
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            /// <summary>
            /// 通知信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverRequestImGroupOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            /// <summary>
            /// 支持卡片消息可被搜索字段
            /// </summary>
            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            /// <summary>
            /// 是否支持转发, 默认false
            /// </summary>
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// 单聊场域投放参数
        /// </summary>
        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImRobotOpenDeliverModel : TeaModel {
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// IM单聊场域信息
        /// </summary>
        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestImRobotOpenSpaceModel : TeaModel {
            /// <summary>
            /// 支持国际化的LastMessage
            /// </summary>
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            /// <summary>
            /// 通知信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverRequestImRobotOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            /// <summary>
            /// 支持卡片消息可被搜索字段
            /// </summary>
            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            /// <summary>
            /// 是否支持转发, 默认false
            /// </summary>
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// 动态数据源配置
        /// </summary>
        [NameInMap("openDynamicDataConfig")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateAndDeliverRequestOpenDynamicDataConfig : TeaModel {
            /// <summary>
            /// 动态数据源配置列表
            /// </summary>
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                /// <summary>
                /// 回调数据源的常量参数
                /// </summary>
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                /// <summary>
                /// 数据源配置id
                /// </summary>
                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                /// <summary>
                /// 数据源拉取配置
                /// </summary>
                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
                    /// <summary>
                    /// 间隔
                    /// </summary>
                    [NameInMap("interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// 拉取策略 (NONE: 不拉取,无动态数据, INTERVAL: 间隔拉取, ONCE: 只拉取一次)
                    /// </summary>
                    [NameInMap("pullStrategy")]
                    [Validation(Required=false)]
                    public string PullStrategy { get; set; }

                    /// <summary>
                    /// 间隔的时间单位 (SECONDS, MINUTES, HOURS, DAYS)
                    /// </summary>
                    [NameInMap("timeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

        }

        /// <summary>
        /// dt.card//spaceType.spaceId;spaceType.spaceId
        /// </summary>
        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        /// <summary>
        /// 外部业务标识符
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        /// <summary>
        /// 吊顶投放参数
        /// </summary>
        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestTopOpenDeliverModel : TeaModel {
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
        /// 吊顶场域信息
        /// </summary>
        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestTopOpenSpaceModel : TeaModel {
            /// <summary>
            /// 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// 卡片创建者 id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
