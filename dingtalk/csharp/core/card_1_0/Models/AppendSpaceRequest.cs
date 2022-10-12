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
            /// xpn信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public AppendSpaceRequestImGroupOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelNotification : TeaModel {
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
            public AppendSpaceRequestImGroupOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport : TeaModel {
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
        /// IM单聊场域信息
        /// </summary>
        [NameInMap("imSingleOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestImSingleOpenSpaceModel ImSingleOpenSpaceModel { get; set; }
        public class AppendSpaceRequestImSingleOpenSpaceModel : TeaModel {
            /// <summary>
            /// 支持国际化的LastMessage
            /// </summary>
            [NameInMap("lastMessageI18n")]
            [Validation(Required=false)]
            public Dictionary<string, string> LastMessageI18n { get; set; }

            /// <summary>
            /// xpn信息
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public AppendSpaceRequestImSingleOpenSpaceModelNotification Notification { get; set; }
            public class AppendSpaceRequestImSingleOpenSpaceModelNotification : TeaModel {
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
            public AppendSpaceRequestImSingleOpenSpaceModelSearchSupport SearchSupport { get; set; }
            public class AppendSpaceRequestImSingleOpenSpaceModelSearchSupport : TeaModel {
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
            /// 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        /// <summary>
        /// 工作台场域信息
        /// </summary>
        [NameInMap("workBenchOpenSpaceModel")]
        [Validation(Required=false)]
        public AppendSpaceRequestWorkBenchOpenSpaceModel WorkBenchOpenSpaceModel { get; set; }
        public class AppendSpaceRequestWorkBenchOpenSpaceModel : TeaModel {
            /// <summary>
            /// 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

    }

}
