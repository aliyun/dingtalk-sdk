// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetSchemaAndProcessconfigBatchllyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSchemaAndProcessconfigBatchllyResponseBodyResult> Result { get; set; }
        public class GetSchemaAndProcessconfigBatchllyResponseBodyResult : TeaModel {
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("managerList")]
            [Validation(Required=false)]
            public string ManagerList { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processConfig")]
            [Validation(Required=false)]
            public string ProcessConfig { get; set; }

            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            [NameInMap("properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            [NameInMap("schemaContent")]
            [Validation(Required=false)]
            public string SchemaContent { get; set; }

            [NameInMap("visibleScope")]
            [Validation(Required=false)]
            public string VisibleScope { get; set; }

        }

    }

}
