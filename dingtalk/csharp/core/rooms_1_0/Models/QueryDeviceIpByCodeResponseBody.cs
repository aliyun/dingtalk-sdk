// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDeviceIpByCodeResponseBody : TeaModel {
        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryDeviceIpByCodeResponseBodyResult Result { get; set; }
        public class QueryDeviceIpByCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// 设备内网ip
            /// </summary>
            [NameInMap("deviceIp")]
            [Validation(Required=false)]
            public string DeviceIp { get; set; }

        }

    }

}
