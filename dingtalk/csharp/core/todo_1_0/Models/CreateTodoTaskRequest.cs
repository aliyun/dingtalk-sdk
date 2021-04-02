// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CreateTodoTaskRequest : TeaModel {
        /// <summary>
        /// 来源id，接入业务系统侧的唯一标识id
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// 待办标题
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 待办备注描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// 执行者列表
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 参与者列表
        /// </summary>
        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// 详情页url跳转地址
        /// </summary>
        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestDetailUrl DetailUrl { get; set; }
        public class CreateTodoTaskRequestDetailUrl : TeaModel {
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }
        };

        /// <summary>
        /// 待办重复规则配置
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// 待办提醒规则配置
        /// </summary>
        [NameInMap("reminder")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestReminder Reminder { get; set; }
        public class CreateTodoTaskRequestReminder : TeaModel {
            [NameInMap("channel")]
            [Validation(Required=false)]
            public int? Channel { get; set; }
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<CreateTodoTaskRequestReminderRules> Rules { get; set; }
            public class CreateTodoTaskRequestReminderRules : TeaModel {
                public string BaseTime { get; set; }
                public long? Offset { get; set; }
            }
        };

        /// <summary>
        /// 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
        /// </summary>
        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreateTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("singleChat")]
            [Validation(Required=false)]
            public string SingleChat { get; set; }
            [NameInMap("groupChat")]
            [Validation(Required=false)]
            public string GroupChat { get; set; }
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }
            [NameInMap("canlender")]
            [Validation(Required=false)]
            public string Canlender { get; set; }
        };

        /// <summary>
        /// 当前操作者id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
