// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class AppCreateEnterpriseTodoTaskRequest : TeaModel {
        [NameInMap("bizCategoryId")]
        [Validation(Required=false)]
        public string BizCategoryId { get; set; }

        [NameInMap("bizCreatedTime")]
        [Validation(Required=false)]
        public long? BizCreatedTime { get; set; }

        [NameInMap("customFields")]
        [Validation(Required=false)]
        public List<AppCreateEnterpriseTodoTaskRequestCustomFields> CustomFields { get; set; }
        public class AppCreateEnterpriseTodoTaskRequestCustomFields : TeaModel {
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldLink")]
            [Validation(Required=false)]
            public string FieldLink { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public AppCreateEnterpriseTodoTaskRequestDetailUrl DetailUrl { get; set; }
        public class AppCreateEnterpriseTodoTaskRequestDetailUrl : TeaModel {
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public AppCreateEnterpriseTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class AppCreateEnterpriseTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("assistance")]
            [Validation(Required=false)]
            public string Assistance { get; set; }

            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("sourceTitle")]
        [Validation(Required=false)]
        public string SourceTitle { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("toolbarTemplateKey")]
        [Validation(Required=false)]
        public string ToolbarTemplateKey { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
