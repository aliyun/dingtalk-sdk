// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverAICardRequest : TeaModel {
        [NameInMap("a2uiAnnotations")]
        [Validation(Required=false)]
        public List<CreateAndDeliverAICardRequestA2uiAnnotations> A2uiAnnotations { get; set; }
        public class CreateAndDeliverAICardRequestA2uiAnnotations : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("surfaceId")]
            [Validation(Required=false)]
            public string SurfaceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("a2uiMessages")]
        [Validation(Required=false)]
        public List<string> A2uiMessages { get; set; }

        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        [NameInMap("bizContext")]
        [Validation(Required=false)]
        public Dictionary<string, string> BizContext { get; set; }

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

        [NameInMap("cardAtUserIds")]
        [Validation(Required=false)]
        public List<string> CardAtUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSING</para>
        /// </summary>
        [NameInMap("flowStatus")]
        [Validation(Required=false)]
        public string FlowStatus { get; set; }

        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public CreateAndDeliverAICardRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class CreateAndDeliverAICardRequestImGroupOpenDeliverModel : TeaModel {
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverAICardRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class CreateAndDeliverAICardRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverAICardRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverAICardRequestImGroupOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverAICardRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverAICardRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
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
        public CreateAndDeliverAICardRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class CreateAndDeliverAICardRequestImRobotOpenDeliverModel : TeaModel {
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

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public CreateAndDeliverAICardRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class CreateAndDeliverAICardRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public CreateAndDeliverAICardRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class CreateAndDeliverAICardRequestImRobotOpenSpaceModelNotification : TeaModel {
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                [NameInMap("notificationOff")]
                [Validation(Required=false)]
                public bool? NotificationOff { get; set; }

            }

            [NameInMap("searchSupport")]
            [Validation(Required=false)]
            public CreateAndDeliverAICardRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class CreateAndDeliverAICardRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtv1.card//im_group.cid_example</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("protocolVersion")]
        [Validation(Required=false)]
        public string ProtocolVersion { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
