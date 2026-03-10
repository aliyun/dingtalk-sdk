// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateShortcutForMigrateRequest : TeaModel {
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("sourceResourceId")]
        [Validation(Required=false)]
        public string SourceResourceId { get; set; }

        [NameInMap("sourceResourceType")]
        [Validation(Required=false)]
        public string SourceResourceType { get; set; }

        [NameInMap("targetResourceId")]
        [Validation(Required=false)]
        public string TargetResourceId { get; set; }

        [NameInMap("targetResourceName")]
        [Validation(Required=false)]
        public string TargetResourceName { get; set; }

        [NameInMap("targetResourceType")]
        [Validation(Required=false)]
        public string TargetResourceType { get; set; }

    }

}
