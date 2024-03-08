// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateCardRequest : TeaModel {
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        [NameInMap("callbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        [NameInMap("cardData")]
        [Validation(Required=false)]
        public CreateCardRequestCardData CardData { get; set; }
        public class CreateCardRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class CreateCardRequestCoFeedOpenSpaceModel : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateCardRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardRequestImGroupOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
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

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateCardRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardRequestImRobotOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
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

        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class CreateCardRequestImSingleOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateCardRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class CreateCardRequestImSingleOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateCardRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateCardRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
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
        public CreateCardRequestOpenDynamicDataConfig OpenDynamicDataConfig { get; set; }
        public class CreateCardRequestOpenDynamicDataConfig : TeaModel {
            [NameInMap("dynamicDataSourceConfigs")]
            [Validation(Required=false)]
            public List<CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
            public class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs : TeaModel {
                [NameInMap("constParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> ConstParams { get; set; }

                [NameInMap("dynamicDataSourceId")]
                [Validation(Required=false)]
                public string DynamicDataSourceId { get; set; }

                [NameInMap("pullConfig")]
                [Validation(Required=false)]
                public CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                public class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig : TeaModel {
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

        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateCardRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class CreateCardRequestTopOpenSpaceModel : TeaModel {
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
