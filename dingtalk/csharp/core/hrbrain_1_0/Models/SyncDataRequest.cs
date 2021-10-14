// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class SyncDataRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("etlTime")]
        [Validation(Required=false)]
        public string EtlTime { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

    }

}
