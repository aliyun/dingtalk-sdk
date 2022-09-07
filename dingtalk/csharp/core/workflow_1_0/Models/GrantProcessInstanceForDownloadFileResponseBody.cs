// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GrantProcessInstanceForDownloadFileResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GrantProcessInstanceForDownloadFileResponseBodyResult Result { get; set; }
        public class GrantProcessInstanceForDownloadFileResponseBodyResult : TeaModel {
            /// <summary>
            /// 文件下载地址。
            /// </summary>
            [NameInMap("downloadUri")]
            [Validation(Required=false)]
            public string DownloadUri { get; set; }

            /// <summary>
            /// 文件ID。
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// 钉盘空间ID。
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        /// <summary>
        /// 接口调用是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
