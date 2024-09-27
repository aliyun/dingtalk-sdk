// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateCardWithDelegateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>routekey-7931</para>
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STREAM</para>
        /// </summary>
        [NameInMap("callbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestCardData CardData { get; set; }
        public class CreateCardWithDelegateRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0aa776f-79ac-4e13-f838-749aae913bc7</para>
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateCardWithDelegateRequestCoFeedOpenSpaceModel : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateCardWithDelegateRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>你收到1条新消息</para>
                /// </summary>
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@lALPDgQ9q8hFhlHNAXzNAqI</para>
                /// </summary>
                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</para>
                /// </summary>
                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateCardWithDelegateRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@lALPDgQ9q8hFhlHNAXzNAqI</para>
                /// </summary>
                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</para>
                /// </summary>
                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class CreateCardWithDelegateRequestImSingleOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
                [NameInMap("searchDesc")]
                [Validation(Required=false)]
                public string SearchDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@lALPDgQ9q8hFhlHNAXzNAqI</para>
                /// </summary>
                [NameInMap("searchIcon")]
                [Validation(Required=false)]
                public string SearchIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;zh_CN&quot;:&quot;待办&quot;,&quot;zh_TW&quot;:&quot;待辦&quot;,&quot;en_US&quot;:&quot;ToDo&quot;}</para>
                /// </summary>
                [NameInMap("searchTypeName")]
                [Validation(Required=false)]
                public string SearchTypeName { get; set; }

            }

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("openDynamicDataConfig")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateCardWithDelegateRequestOpenDynamicDataConfig : TeaModel {
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ds-01</para>
                /// </summary>
                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
                    [NameInMap("interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>INTERVAL</para>
                    /// </summary>
                    [NameInMap("pullStrategy")]
                    [Validation(Required=false)]
                    public string PullStrategy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SECONDS</para>
                    /// </summary>
                    [NameInMap("timeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycard-07921</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardWithDelegateRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateCardWithDelegateRequestTopOpenSpaceModel : TeaModel {
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager1234</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
