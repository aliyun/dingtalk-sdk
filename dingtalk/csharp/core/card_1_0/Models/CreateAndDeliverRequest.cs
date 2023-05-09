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

        [NameInMap("callbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCardData CardData { get; set; }
        public class CreateAndDeliverRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenDeliverModel : TeaModel {
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateAndDeliverRequestCoFeedOpenSpaceModel : TeaModel {
            [NameInMap("coolAppCode")]
            [Validation(Required=false)]
            public string CoolAppCode { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestDocOpenDeliverModel : TeaModel {
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

            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

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
        public CreateAndDeliverRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class CreateAndDeliverRequestImRobotOpenDeliverModel : TeaModel {
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

        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

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
