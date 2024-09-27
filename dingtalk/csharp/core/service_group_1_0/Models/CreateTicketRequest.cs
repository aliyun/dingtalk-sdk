// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateTicketRequest : TeaModel {
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
        public CreateTicketRequestNotify Notify { get; set; }
        public class CreateTicketRequestNotify : TeaModel {
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
        public CreateTicketRequestSceneContext SceneContext { get; set; }
        public class CreateTicketRequestSceneContext : TeaModel {
            [NameInMap("groupMsgs")]
            [Validation(Required=false)]
            public List<CreateTicketRequestSceneContextGroupMsgs> GroupMsgs { get; set; }
            public class CreateTicketRequestSceneContextGroupMsgs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>a0ba57d5d29a48b51d0eca48da6b1d09</para>
            /// </summary>
            [NameInMap("topicId")]
            [Validation(Required=false)]
            public string TopicId { get; set; }

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
