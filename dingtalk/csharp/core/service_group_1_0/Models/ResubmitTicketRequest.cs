// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ResubmitTicketRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("customFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        [NameInMap("notify")]
        [Validation(Required=false)]
        public ResubmitTicketRequestNotify Notify { get; set; }
        public class ResubmitTicketRequestNotify : TeaModel {
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }

            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTemplateBizId")]
        [Validation(Required=false)]
        public string OpenTemplateBizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processorUnionIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUnionIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("sceneContext")]
        [Validation(Required=false)]
        public ResubmitTicketRequestSceneContext SceneContext { get; set; }
        public class ResubmitTicketRequestSceneContext : TeaModel {
            [NameInMap("groupMsgs")]
            [Validation(Required=false)]
            public List<ResubmitTicketRequestSceneContextGroupMsgs> GroupMsgs { get; set; }
            public class ResubmitTicketRequestSceneContextGroupMsgs : TeaModel {
                [NameInMap("anchor")]
                [Validation(Required=false)]
                public bool? Anchor { get; set; }

                [NameInMap("openMsgId")]
                [Validation(Required=false)]
                public string OpenMsgId { get; set; }

                [NameInMap("topicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("relevantorUnionIds")]
            [Validation(Required=false)]
            public List<string> RelevantorUnionIds { get; set; }

        }

        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public ResubmitTicketRequestTicketMemo TicketMemo { get; set; }
        public class ResubmitTicketRequestTicketMemo : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ResubmitTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class ResubmitTicketRequestTicketMemoAttachments : TeaModel {
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
