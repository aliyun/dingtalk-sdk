// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class ReleaseGrayOrgSetRequest : TeaModel {
        /// <summary>
        /// 离线包ID
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 灰度企业corpId列表
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<string> Value { get; set; }

        /// <summary>
        /// 离线包版本号
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
