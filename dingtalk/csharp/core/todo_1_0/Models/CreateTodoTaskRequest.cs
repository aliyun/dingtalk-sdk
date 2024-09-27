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
                public Dictionary<string, object> Header { get; set; }

            }

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

        [NameInMap("bizCategoryId")]
        [Validation(Required=false)]
        public string BizCategoryId { get; set; }

        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<CreateTodoTaskRequestContentFieldList> ContentFieldList { get; set; }
        public class CreateTodoTaskRequestContentFieldList : TeaModel {
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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

        }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("isOnlyShowExecutor")]
        [Validation(Required=false)]
        public bool? IsOnlyShowExecutor { get; set; }

        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreateTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreateTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
