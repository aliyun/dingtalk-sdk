// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class HPackageListGetResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<HPackageListGetResponseBodyList> List { get; set; }
        public class HPackageListGetResponseBodyList : TeaModel {
            [NameInMap("avaliable")]
            [Validation(Required=false)]
            public long? Avaliable { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("operationTime")]
            [Validation(Required=false)]
            public long? OperationTime { get; set; }

            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public long? PackageSize { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
