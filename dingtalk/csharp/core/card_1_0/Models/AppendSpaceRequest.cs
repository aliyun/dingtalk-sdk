// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class AppendSpaceRequest : TeaModel {
        /// <summary>
        /// 协作场域信息
        /// </summary>
        [NameInMap("coFeedOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestCoFeedOpenSpaceModel CoFeedOpenSpaceModel { get; set; }
        public class AppendSpaceRequestCoFeedOpenSpaceModel : TeaModel {
            /// <summary>
            /// 【必填】标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// IM群聊场域信息
        /// </summary>
        [NameInMap("imGroupOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestImGroupOpenSpaceModel ImGroupOpenSpaceModel { get; set; }
        public class AppendSpaceRequestImGroupOpenSpaceModel : TeaModel {
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
            public AppendSpaceRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// 【条件必填】通知内容
                /// 
                /// 【注意】若不填写则使用默认文案：如你收到1条新消息
                /// </summary>
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                /// <summary>
                /// 是否关闭推送通知，默认为false
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
            public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// 卡片的具体描述
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
            /// 是否支持转发, 默认false
            /// </summary>
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// IM群聊场域信息
        /// </summary>
        [NameInMap("imRobotOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestImRobotOpenSpaceModel ImRobotOpenSpaceModel { get; set; }
        public class AppendSpaceRequestImRobotOpenSpaceModel : TeaModel {
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
            public AppendSpaceRequestImRobotOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImRobotOpenSpaceModelNotification : TeaModel {
                /// <summary>
                /// 【条件必填】通知内容
                /// 
                /// 【注意】若不填写则使用默认文案：如你收到1条新消息
                /// </summary>
                [NameInMap("alertContent")]
                [Validation(Required=false)]
                public string AlertContent { get; set; }

                /// <summary>
                /// 是否关闭推送通知，默认为false
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
            public AppendSpaceRequestImRobotOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImRobotOpenSpaceModelSearchSupport : TeaModel {
                /// <summary>
                /// 卡片的具体描述
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
            /// 是否支持转发, 默认false
            /// </summary>
            [NameInMap("supportForward")]
            [Validation(Required=false)]
            public bool? SupportForward { get; set; }

        }

        /// <summary>
        /// 唯一标识一张卡片的外部Id
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 吊顶场域信息
        /// </summary>
        [NameInMap("topOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestTopOpenSpaceModel TopOpenSpaceModel { get; set; }
        public class AppendSpaceRequestTopOpenSpaceModel : TeaModel {
            /// <summary>
            /// 【必填】场域类型
            /// 
            /// 吊顶无其他场域属性，通过设置spaeType为ONE_BOX使卡片支持吊顶场域
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

    }

}
