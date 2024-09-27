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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("avaliable")]
            [Validation(Required=false)]
            public long? Avaliable { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1669261911344</para>
            /// </summary>
            [NameInMap("operationTime")]
            [Validation(Required=false)]
            public long? OperationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public long? PackageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00000000Azksf</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
