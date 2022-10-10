// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateStsTokenRequest : TeaModel {
        /// <summary>
        /// 设备sn码
        /// </summary>
        [NameInMap("deviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// sts类型: oss/sls
        /// </summary>
        [NameInMap("stsType")]
        [Validation(Required=false)]
        public string StsType { get; set; }

    }

}
