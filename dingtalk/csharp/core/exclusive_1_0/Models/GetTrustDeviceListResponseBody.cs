// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetTrustDeviceListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTrustDeviceListResponseBodyData> Data { get; set; }
        public class GetTrustDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// 员工Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 平台类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// mac地址
            /// </summary>
            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

        }

    }

}
