// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateTrustedDeviceBatchRequest : TeaModel {
        /// <summary>
        /// mac地址列表
        /// </summary>
        [NameInMap("macAddressList")]
        [Validation(Required=false)]
        public List<string> MacAddressList { get; set; }

        /// <summary>
        /// 平台
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
