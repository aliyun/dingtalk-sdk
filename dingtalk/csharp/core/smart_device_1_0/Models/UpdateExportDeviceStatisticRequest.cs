// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class UpdateExportDeviceStatisticRequest : TeaModel {
        [NameInMap("creatorCorpId")]
        [Validation(Required=false)]
        public string CreatorCorpId { get; set; }

        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<UpdateExportDeviceStatisticRequestRecords> Records { get; set; }
        public class UpdateExportDeviceStatisticRequestRecords : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

            [NameInMap("sheetName")]
            [Validation(Required=false)]
            public string SheetName { get; set; }

        }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
