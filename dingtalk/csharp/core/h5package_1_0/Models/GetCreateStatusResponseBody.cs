// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh5package_1_0.Models
{
    public class GetCreateStatusResponseBody : TeaModel {
        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("buildTime")]
        [Validation(Required=false)]
        public long? BuildTime { get; set; }

        /// <summary>
        /// 任务是否已结束
        /// </summary>
        [NameInMap("finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// H5离线包体积，单位Byte
        /// </summary>
        [NameInMap("packageSize")]
        [Validation(Required=false)]
        public long? PackageSize { get; set; }

        /// <summary>
        /// 任务状态。1：构建中；2：成功；3：失败；5：超时。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 创建离线包接口返回的taskId
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// H5离线包版本号
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
