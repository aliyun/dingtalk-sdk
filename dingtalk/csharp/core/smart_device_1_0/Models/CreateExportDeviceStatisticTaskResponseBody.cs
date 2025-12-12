// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class CreateExportDeviceStatisticTaskResponseBody : TeaModel {
        [NameInMap("exportStatisticTaskDTO")]
        [Validation(Required=false)]
        public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO ExportStatisticTaskDTO { get; set; }
        public class CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTO : TeaModel {
            [NameInMap("aiSheetDocumentOpenDTO")]
            [Validation(Required=false)]
            public CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO AiSheetDocumentOpenDTO { get; set; }
            public class CreateExportDeviceStatisticTaskResponseBodyExportStatisticTaskDTOAiSheetDocumentOpenDTO : TeaModel {
                [NameInMap("aiSheetTemplateId")]
                [Validation(Required=false)]
                public long? AiSheetTemplateId { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("documentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                [NameInMap("documentName")]
                [Validation(Required=false)]
                public string DocumentName { get; set; }

                [NameInMap("documentUrl")]
                [Validation(Required=false)]
                public string DocumentUrl { get; set; }

            }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
