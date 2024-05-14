// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverWithDelegateRequest : TeaModel {
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        [NameInMap("callbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestCardData CardData { get; set; }
        public class CreateAndDeliverWithDelegateRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel : TeaModel {
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel : TeaModel {
            [NameInMap("coolAppCode")]
            [Validation(Required=false)]
            public string CoolAppCode { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestDocOpenDeliverModel : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
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

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
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

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("imSingleOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel ImSingleOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

        }

        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
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

            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        [NameInMap("openDynamicDataConfig")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig : TeaModel {
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestTopOpenDeliverModel : TeaModel {
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
        public CreateAndDeliverWithDelegateRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateAndDeliverWithDelegateRequestTopOpenSpaceModel : TeaModel {
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
