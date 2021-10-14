// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateTicketRequest : TeaModel {
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

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 通知接收人配置
        /// </summary>
        [NameInMap("notify")]
        [Validation(Required=false)]
        public CreateTicketRequestNotify Notify { get; set; }
        public class CreateTicketRequestNotify : TeaModel {
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }
            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }
        };

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
        public CreateTicketRequestSceneContext SceneContext { get; set; }
        public class CreateTicketRequestSceneContext : TeaModel {
            [NameInMap("groupMsgs")]
            [Validation(Required=false)]
            public List<CreateTicketRequestSceneContextGroupMsgs> GroupMsgs { get; set; }
            public class CreateTicketRequestSceneContextGroupMsgs : TeaModel {
                public string OpenMsgId { get; set; }
                public bool? Anchor { get; set; }
            }
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }
            [NameInMap("relevantorUnionIds")]
            [Validation(Required=false)]
            public List<string> RelevantorUnionIds { get; set; }
            [NameInMap("topicId")]
            [Validation(Required=false)]
            public string TopicId { get; set; }
        };

        /// <summary>
        /// 工单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
