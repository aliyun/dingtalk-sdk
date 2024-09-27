// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class AppendSpaceRequest : TeaModel {
        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class AppendSpaceRequestCoFeedOpenSpaceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx卡片</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class AppendSpaceRequestImGroupOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public AppendSpaceRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelNotification : TeaModel {
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
            public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
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

        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class AppendSpaceRequestImRobotOpenSpaceModel : TeaModel {
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            [NameInMap("notification")]
            [Validation(Required=false)]
            public AppendSpaceRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImRobotOpenSpaceModelNotification : TeaModel {
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
            public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx_yyyy_123456</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class AppendSpaceRequestTopOpenSpaceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE_BOX</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

    }

}
