// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendMsgByTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestMessageContent MessageContent { get; set; }
        public class SendMsgByTaskRequestMessageContent : TeaModel {
            [NameInMap("atActiveMemberNum")]
            [Validation(Required=false)]
            public long? AtActiveMemberNum { get; set; }

            [NameInMap("atActiveUser")]
            [Validation(Required=false)]
            public bool? AtActiveUser { get; set; }

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

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            [NameInMap("remind")]
            [Validation(Required=false)]
            public bool? Remind { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("top")]
            [Validation(Required=false)]
            public bool? Top { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("queryGroup")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestQueryGroup QueryGroup { get; set; }
        public class SendMsgByTaskRequestQueryGroup : TeaModel {
            [NameInMap("groupTagNames")]
            [Validation(Required=false)]
            public List<string> GroupTagNames { get; set; }

            [NameInMap("lastActiveDateFilterType")]
            [Validation(Required=false)]
            public string LastActiveDateFilterType { get; set; }

            [NameInMap("lastActiveTimeEnd")]
            [Validation(Required=false)]
            public string LastActiveTimeEnd { get; set; }

            [NameInMap("lastActiveTimeStart")]
            [Validation(Required=false)]
            public string LastActiveTimeStart { get; set; }

            [NameInMap("openConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("queryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sendConfig")]
        [Validation(Required=false)]
        public SendMsgByTaskRequestSendConfig SendConfig { get; set; }
        public class SendMsgByTaskRequestSendConfig : TeaModel {
            [NameInMap("needUrlTrack")]
            [Validation(Required=false)]
            public bool? NeedUrlTrack { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            [NameInMap("urlTrackConfig")]
            [Validation(Required=false)]
            public List<SendMsgByTaskRequestSendConfigUrlTrackConfig> UrlTrackConfig { get; set; }
            public class SendMsgByTaskRequestSendConfigUrlTrackConfig : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("trackId")]
                [Validation(Required=false)]
                public string TrackId { get; set; }

                [NameInMap("trackUrl")]
                [Validation(Required=false)]
                public string TrackUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
