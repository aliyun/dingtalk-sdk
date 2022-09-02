// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ResubmitTicketRequest : TeaModel {
        /// <summary>
        /// 工单创建人UnionId
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// 自定义组件字段值(JSON格式)
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        [NameInMap("notify")]
        [Validation(Required=false)]
        public ResubmitTicketRequestNotify Notify { get; set; }
        public class ResubmitTicketRequestNotify : TeaModel {
            /// <summary>
            /// 服务群通知接收人（钉钉UnionId）
            /// </summary>
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }

            /// <summary>
            /// 是否向群内推送一个全员可见工单通知卡片
            /// </summary>
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            /// <summary>
            /// 企业工作通知接收人（钉钉UnionId）
            /// </summary>
            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }

        }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 工单模板业务ID
        /// </summary>
        [NameInMap("openTemplateBizId")]
        [Validation(Required=false)]
        public string OpenTemplateBizId { get; set; }

        /// <summary>
        /// 工单开放ID
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// 工单处理人UnionId列表
        /// </summary>
        [NameInMap("processorUnionIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUnionIds { get; set; }

        /// <summary>
        /// 工单场景 SG 或 VOC
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// 工单场景信息
        /// </summary>
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
                /// 勾选消息openMsgId
                /// </summary>
                [NameInMap("openMsgId")]
                [Validation(Required=false)]
                public string OpenMsgId { get; set; }

                [NameInMap("topicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

            }

            /// <summary>
            /// 服务群openConversationId
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 工单相关人UnionId列表
            /// </summary>
            [NameInMap("relevantorUnionIds")]
            [Validation(Required=false)]
            public List<string> RelevantorUnionIds { get; set; }

        }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public ResubmitTicketRequestTicketMemo TicketMemo { get; set; }
        public class ResubmitTicketRequestTicketMemo : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ResubmitTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class ResubmitTicketRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// 文件名
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 文件key
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// 备注文字
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

        /// <summary>
        /// 工单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
