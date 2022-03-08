// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateMiniAppVersionStatusRequest : TeaModel {
        /// <summary>
        /// 小程序id
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// 版本类型
        /// </summary>
        [NameInMap("versionType")]
        [Validation(Required=false)]
        public int? VersionType { get; set; }

    }

}
