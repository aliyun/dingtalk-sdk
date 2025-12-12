// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class CreateExportDeviceStatisticTaskRequest : TeaModel {
        [NameInMap("aiSheetTemplateId")]
        [Validation(Required=false)]
        public long? AiSheetTemplateId { get; set; }

        [NameInMap("creatorCorpId")]
        [Validation(Required=false)]
        public string CreatorCorpId { get; set; }

        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
