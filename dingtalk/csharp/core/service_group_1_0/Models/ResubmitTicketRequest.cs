// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ResubmitTicketRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</para>
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;identifier&quot;:&quot;input1&quot;,&quot;value&quot;:&quot;123&quot;}]</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKWh3GBwsKEiE</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bLkvfXKiSngQiE</para>
        /// </summary>
        [NameInMap("openTemplateBizId")]
        [Validation(Required=false)]
        public string OpenTemplateBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iPbrfXjdNjRoiE</para>
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("processorUnionIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUnionIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SG</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>msgsbY4BzTCNX0/ClUwoTTs7w==</para>
                /// </summary>
                [NameInMap("openMsgId")]
                [Validation(Required=false)]
                public string OpenMsgId { get; set; }

                [NameInMap("topicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cidZBSNlUi/Jq9x76PAXUCrAA==</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>wahaha.txt</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>工单标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
