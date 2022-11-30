// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class HPackageListGetResponseBody : TeaModel {
        /// <summary>
        /// 离线包列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<HPackageListGetResponseBodyList> List { get; set; }
        public class HPackageListGetResponseBodyList : TeaModel {
            /// <summary>
            /// 版本是否可用
            /// </summary>
            [NameInMap("avaliable")]
            [Validation(Required=false)]
            public long? Avaliable { get; set; }

            /// <summary>
            /// 上传者
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 上传是否已完成
            /// </summary>
            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// 上传时间
            /// </summary>
            [NameInMap("operationTime")]
            [Validation(Required=false)]
            public long? OperationTime { get; set; }

            /// <summary>
            /// 离线包大小，单位byte
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public long? PackageSize { get; set; }

            /// <summary>
            /// 版本状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 上传任务ID
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
