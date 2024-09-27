// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverRequest : TeaModel {
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
        public CreateAndDeliverRequestCardData CardData { get; set; }
        public class CreateAndDeliverRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx_biz_tag</para>
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1665473229000</para>
            /// </summary>
            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenSpaceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>coolAppCode123</para>
            /// </summary>
            [NameInMap("coolAppCode")]
            [Validation(Required=false)]
            public string CoolAppCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx卡片</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestDocOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx_biz_tag</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImGroupOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingg3xmqdkpaojuakm8</para>
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverRequestImGroupOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>你收到了一个卡片消息</para>
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
            public CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>卡片的具体描述</para>
                /// </summary>
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

        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImRobotOpenDeliverModel : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingg3xmqdkpaojuakm8</para>
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverRequestImRobotOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>你收到了一个卡片消息</para>
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
            public CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>卡片的具体描述</para>
                /// </summary>
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

        [NameInMap("imSingleOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImSingleOpenDeliverModel ImSingleOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImSingleOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

        }

        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestImSingleOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverRequestImSingleOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>你收到了一个卡片消息</para>
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
            public CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>卡片的具体描述</para>
                /// </summary>
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
        public CreateAndDeliverRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateAndDeliverRequestOpenDynamicDataConfig : TeaModel {
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
                    [NameInMap("interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("pullStrategy")]
                    [Validation(Required=false)]
                    public string PullStrategy { get; set; }

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
        /// <para>dtv1.card//im_group.cidp4Gh<em><b><b><b>VCQ==;im_robot.manager</b></b>67;im_robot.staff</b></em><em>89;co_feed.manager</em><em><b>67;one_box.cidp4Gh</b></em>****VCQ==;</para>
        /// </summary>
        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestTopOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1665473229000</para>
            /// </summary>
            [NameInMap("expiredTimeMillis")]
            [Validation(Required=false)]
            public long? ExpiredTimeMillis { get; set; }

            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestTopOpenSpaceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE_BOX</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
