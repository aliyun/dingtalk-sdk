/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class CheckInCrowdsByMobileRequest : TeaModel {
        /// <summary>
        /// 人群id
        /// </summary>
        [NameInMap("crowdIds")]
        [Validation(Required=false)]
        public byte[] CrowdIds { get; set; }

        /// <summary>
        /// 要校验的用户手机号，AES256+Base64方式加密
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

    }

}
