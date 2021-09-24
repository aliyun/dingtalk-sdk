// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class DecodeBadgeCodeRequest : TeaModel {
        /// <summary>
        /// 码值
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

    }

}
