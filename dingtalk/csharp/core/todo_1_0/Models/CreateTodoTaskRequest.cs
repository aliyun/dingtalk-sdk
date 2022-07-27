// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CreateTodoTaskRequest : TeaModel {
        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskRequestActionList> ActionList { get; set; }
        public class CreateTodoTaskRequestActionList : TeaModel {
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("buttonStyleType")]
            [Validation(Required=false)]
            public int? ButtonStyleType { get; set; }

            [NameInMap("param")]
            [Validation(Required=false)]
            public CreateTodoTaskRequestActionListParam Param { get; set; }
            public class CreateTodoTaskRequestActionListParam : TeaModel {
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }
                [NameInMap("header")]
                [Validation(Required=false)]
                public Dictionary<string, string> Header { get; set; }
            };

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// 二级分类
        /// </summary>
        [NameInMap("bizCategoryId")]
        [Validation(Required=false)]
        public string BizCategoryId { get; set; }

        /// <summary>
        /// 待办卡片内容区表单自定义字段列表
        /// </summary>
        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskRequestContentFieldList> ContentFieldList { get; set; }
        public class CreateTodoTaskRequestContentFieldList : TeaModel {
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
        /// 创建者id，需传用户的unionId
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
        /// 截止时间
        /// </summary>
        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// 执行者列表，需传用户的unionId
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// 生成的待办是否仅展示在执行者的待办列表中
        /// </summary>
        [NameInMap("isOnlyShowExecutor")]
        [Validation(Required=false)]
        public bool? IsOnlyShowExecutor { get; set; }

        /// <summary>
        /// 通知提醒配置
        /// </summary>
        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreateTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }
        };

        /// <summary>
        /// 参与者列表，需传用户的unionId
        /// </summary>
        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

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
        /// 当前操作者id，需传用户的unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
