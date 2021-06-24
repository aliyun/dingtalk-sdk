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
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

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
        /// 执行者列表，需传用户的unionId
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 参与者列表，需传用户的unionId
        /// </summary>
        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// 待办卡片类型id
        /// </summary>
        [NameInMap("cardTypeId")]
        [Validation(Required=false)]
        public string CardTypeId { get; set; }

        /// <summary>
        /// 内容区表单字段配置
        /// </summary>
        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<UpdateTodoTaskRequestContentFieldList> ContentFieldList { get; set; }
        public class UpdateTodoTaskRequestContentFieldList : TeaModel {
            /// <summary>
            /// 字段唯一标识
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            /// <summary>
            /// 字段值
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 业务来源展示名称
        /// </summary>
        [NameInMap("sourceTitle")]
        [Validation(Required=false)]
        public string SourceTitle { get; set; }

        /// <summary>
        /// 当前操作者id，需传用户的unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
