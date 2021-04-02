// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class UpdateTodoTaskRequest : TeaModel {
        /// <summary>
        /// 待办标题
        /// </summary>
        [NameInMap("sucject")]
        [Validation(Required=false)]
        public string Sucject { get; set; }

        /// <summary>
        /// 待办描述备注
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
        /// 完成状态
        /// </summary>
        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

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
        public UpdateTodoTaskRequestDetailUrl DetailUrl { get; set; }
        public class UpdateTodoTaskRequestDetailUrl : TeaModel {
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
        public UpdateTodoTaskRequestReminder Reminder { get; set; }
        public class UpdateTodoTaskRequestReminder : TeaModel {
            [NameInMap("channel")]
            [Validation(Required=false)]
            public int? Channel { get; set; }
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<UpdateTodoTaskRequestReminderRules> Rules { get; set; }
            public class UpdateTodoTaskRequestReminderRules : TeaModel {
                public string BaseTime { get; set; }
                public long? Offset { get; set; }
            }
        };

        /// <summary>
        /// 当前操作者id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
