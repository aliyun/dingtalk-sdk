// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class PublishInnerAppVersionRequest : TeaModel {
        /// <summary>
        /// 小程序版本id，用于唯一标识小程序版本信息。
        /// </summary>
        [NameInMap("appVersionId")]
        [Validation(Required=false)]
        public long? AppVersionId { get; set; }

        /// <summary>
        /// 小程序是否在PC端发布，true表示发布移动端和PC端，false表示只发布移动端
        /// </summary>
        [NameInMap("miniAppOnPc")]
        [Validation(Required=false)]
        public bool? MiniAppOnPc { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

        /// <summary>
        /// 小程序发布类型，”online“表示发布线上版本，”experience“表示发布体验版本
        /// </summary>
        [NameInMap("publishType")]
        [Validation(Required=false)]
        public string PublishType { get; set; }

    }

}
