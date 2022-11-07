// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateCardRequest : TeaModel {
        /// <summary>
        /// 卡片回调时的路由 Key，用于查询注册的 callbackUrl
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        [NameInMap("cardAtUserIds")]
        [Validation(Required=false)]
        public List<string> CardAtUserIds { get; set; }

        /// <summary>
        /// 卡片数据
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateCardRequestCardData CardData { get; set; }
        public class CreateCardRequestCardData : TeaModel {
            /// <summary>
            /// 卡片模板内容替换参数，普通文本类型
            /// ● key：参数名
            /// ● value: 参数值
            /// </summary>
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// 卡片的模版 Id
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 协作场域信息
        /// </summary>
        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateCardRequestCoFeedOpenSpaceModel : TeaModel {
            /// <summary>
            /// 卡片标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// IM 群聊场域信息
        /// </summary>
        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateCardRequestImGroupOpenSpaceModel : TeaModel {
            /// <summary>
            /// 支持国际化的LastMessage
            /// key为语言枚举值，value为lastMessage内容
            /// 目前支持的语言枚举值：
            /// 简体中文: ZH_CN
            /// 繁体中文: ZH_TW
            /// 英文： EN_US
            /// 日语: JA_JP
            /// 越南语: VI_VN
            /// </summary>
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            /// <summary>
            /// 卡片的通知属性信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardRequestImGroupOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// 【条件必填】通知内容
                /// 若不填写则使用默认文案：如你收到1条新消息
                /// </summary>
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                /// <summary>
                /// 是否推送通知，默认为 false
                /// </summary>
                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            /// <summary>
            /// 支持卡片消息可被搜索字段
            /// </summary>
            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                ///  【条件必填】供消息展示与搜索的字段
                ///  【注意】最大限制200个字符，超过存储截断200
                /// </summary>
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                /// <summary>
                /// 类型的icon，供搜索展示使用
                /// </summary>
                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                /// <summary>
                /// 卡片类型名
                /// </summary>
                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            /// <summary>
            /// 是否支持转发, 默认 false
            /// </summary>
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// IM 单聊场域信息
        /// </summary>
        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class CreateCardRequestImSingleOpenSpaceModel : TeaModel {
            /// <summary>
            /// 支持国际化的LastMessage
            /// key为语言枚举值，value为lastMessage内容
            /// 目前支持的语言枚举值：
            /// 简体中文: ZH_CN
            /// 繁体中文: ZH_TW
            /// 英文： EN_US
            /// 日语: JA_JP
            /// 越南语: VI_VN
            /// </summary>
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            /// <summary>
            /// 卡片的通知属性信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardRequestImSingleOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// 【条件必填】通知内容
                /// 若不填写则使用默认文案：如你收到1条新消息
                /// </summary>
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                /// <summary>
                /// 是否推送通知，默认为 false
                /// </summary>
                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            /// <summary>
            /// 支持卡片消息可被搜索字段
            /// </summary>
            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// 【条件必填】供消息展示与搜索的字段
                ///  【注意】最大限制200个字符，超过存储截断200
                /// </summary>
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                /// <summary>
                /// 类型的icon，供搜索展示使用
                /// </summary>
                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                /// <summary>
                /// 卡片类型名
                /// </summary>
                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            /// <summary>
            /// 是否支持转发, 默认 false
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
        public CreateCardRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateCardRequestOpenDynamicDataConfig : TeaModel {
            /// <summary>
            /// 动态数据替换关系
            /// ● key：变量名
            /// ● value：数据映射的配置
            /// </summary>
            [NameInMap("dynamicDataMapping")]
            [Validation(Required=false)]
            public Dictionary<string, OpenDynamicDataConfigDynamicDataMappingValue> DynamicDataMapping { get; set; }

            /// <summary>
            /// 动态数据映射方法，可选值
            /// ● REPLACE_WITHOUT_MAPPING：直接返回动态数据
            /// ● MAPPING_BY_KEY：根据指定的规则，将返回数据映射到卡片数据上
            /// 默认值：REPLACE_WITHOUT_MAPPING
            /// </summary>
            [NameInMap("dynamicDataMappingMethod")]
            [Validation(Required=false)]
            public string DynamicDataMappingMethod { get; set; }

            /// <summary>
            /// 动态数据源配置列表
            /// </summary>
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                /// <summary>
                /// 回调数据源的常量参数
                /// </summary>
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                /// <summary>
                /// 【条件必填】数据源的唯一 ID
                /// </summary>
                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                /// <summary>
                /// 【条件必填】数据源拉取配置
                /// </summary>
                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
                    /// <summary>
                    /// 拉取的间隔时间，只在将 pullStrategy 设置为 INTERVAL 的时候生效
                    /// </summary>
                    [NameInMap("interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// 【条件必填】拉取策略，可选值：
                    /// ● NONE：不拉取，无动态数据
                    /// ● INTERVAL：间隔拉取
                    /// ● ONCE：只拉取一次
                    /// </summary>
                    [NameInMap("pullStrategy")]
                    [Validation(Required=false)]
                    public string PullStrategy { get; set; }

                    /// <summary>
                    /// 拉取的间隔时间的单位，只在将 pullStrategy 设置为 INTERVAL 的时候生效。 可选值：
                    /// ● SECONDS
                    /// ● MINUTES
                    /// ● HOURS
                    /// ● DAYS
                    /// </summary>
                    [NameInMap("timeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

        }

        /// <summary>
        /// 唯一标示卡片的外部编码
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 用户的私有数据。
        /// ● key：userId
        /// ● value：用户私有数据（cardData）
        /// </summary>
        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        /// <summary>
        /// 吊顶场域信息
        /// </summary>
        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateCardRequestTopOpenSpaceModel : TeaModel {
            /// <summary>
            /// 吊顶无其他场域属性，通过增加spaeType使卡片支持吊顶场域；吊顶对应spaceType为: ONE_BOX
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// 卡片创建者的 userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

        /// <summary>
        /// 工作台场域信息
        /// </summary>
        [NameInMap("workBenchOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestWorkBenchOpenSpaceModel WorkBenchOpenSpaceModel { get; set; }
        public class CreateCardRequestWorkBenchOpenSpaceModel : TeaModel {
            /// <summary>
            /// 工作台无其他场域属性，通过增加spaeType使卡片支持工作台场域;工作台对应spaceType为: WORK_BENCH
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

    }

}
