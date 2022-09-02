// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendMsgByTaskRequest : TeaModel {
        /// <summary>
        /// 群发内容
        /// </summary>
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestMessageContent MessageContent { get; set; }
        public class SendMsgByTaskRequestMessageContent : TeaModel {
            /// <summary>
            /// at活跃成员数量
            /// </summary>
            [NameInMap("atActiveMemberNum")]
            [Validation(Required=false)]
            public long? AtActiveMemberNum { get; set; }

            /// <summary>
            /// 是否At活跃成员
            /// </summary>
            [NameInMap("atActiveUser")]
            [Validation(Required=false)]
            public bool? AtActiveUser { get; set; }

            /// <summary>
            /// 是否At全部人员
            /// </summary>
            [NameInMap("atAll")]
            [Validation(Required=false)]
            public bool? AtAll { get; set; }

            [NameInMap("btns")]
            [Validation(Required=false)]
            public List<SendMsgByTaskRequestMessageContentBtns> Btns { get; set; }
            public class SendMsgByTaskRequestMessageContentBtns : TeaModel {
                [NameInMap("actionURL")]
                [Validation(Required=false)]
                public string ActionURL { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 图片列表
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// 消息类型
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// 是否提醒群成员
            /// </summary>
            [NameInMap("remind")]
            [Validation(Required=false)]
            public bool? Remind { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 是否置顶
            /// </summary>
            [NameInMap("top")]
            [Validation(Required=false)]
            public bool? Top { get; set; }

        }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("queryGroup")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestQueryGroup QueryGroup { get; set; }
        public class SendMsgByTaskRequestQueryGroup : TeaModel {
            /// <summary>
            /// 群标签
            /// </summary>
            [NameInMap("groupTagNames")]
            [Validation(Required=false)]
            public List<string> GroupTagNames { get; set; }

            /// <summary>
            /// 活跃日期筛选类型，ACTIVE=活跃      NOTACTIVE=不活跃
            /// </summary>
            [NameInMap("lastActiveDateFilterType")]
            [Validation(Required=false)]
            public string LastActiveDateFilterType { get; set; }

            /// <summary>
            /// 最近活跃时间的结束时间
            /// </summary>
            [NameInMap("lastActiveTimeEnd")]
            [Validation(Required=false)]
            public string LastActiveTimeEnd { get; set; }

            /// <summary>
            /// 最近活跃时间的开始时间
            /// </summary>
            [NameInMap("lastActiveTimeStart")]
            [Validation(Required=false)]
            public string LastActiveTimeStart { get; set; }

            /// <summary>
            /// 精准圈选-群ID集合
            /// </summary>
            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            /// <summary>
            /// 开放群组ID
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// 群发圈选类型 1. AIMED 精准圈选 2. MULTI_CONDITIONS 多条件圈选
            /// </summary>
            [NameInMap("queryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

        }

        /// <summary>
        /// 发送配置
        /// </summary>
        [NameInMap("sendConfig")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestSendConfig SendConfig { get; set; }
        public class SendMsgByTaskRequestSendConfig : TeaModel {
            /// <summary>
            /// 是否链接追踪
            /// </summary>
            [NameInMap("needUrlTrack")]
            [Validation(Required=false)]
            public bool? NeedUrlTrack { get; set; }

            /// <summary>
            /// 执行时间（sendType=TIMING时传入）
            /// </summary>
            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// 发送类型      * TIMING=定时执行      * INSTANT=立即执行
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            /// <summary>
            /// 链接跟踪配置
            /// </summary>
            [NameInMap("urlTrackConfig")]
            [Validation(Required=false)]
            public List<SendMsgByTaskRequestSendConfigUrlTrackConfig> UrlTrackConfig { get; set; }
            public class SendMsgByTaskRequestSendConfigUrlTrackConfig : TeaModel {
                /// <summary>
                /// 跟踪链接的标题
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 跟踪链接的坑位ID（sg开头）
                /// </summary>
                [NameInMap("trackId")]
                [Validation(Required=false)]
                public string TrackId { get; set; }

                /// <summary>
                /// 跟踪链接URL
                /// </summary>
                [NameInMap("trackUrl")]
                [Validation(Required=false)]
                public string TrackUrl { get; set; }

            }

        }

        /// <summary>
        /// 群发任务名称
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
