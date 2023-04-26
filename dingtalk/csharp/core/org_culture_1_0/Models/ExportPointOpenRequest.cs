// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class ExportPointOpenRequest : TeaModel {
        [NameInMap("exportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        [NameInMap("exportType")]
        [Validation(Required=false)]
        public long? ExportType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
