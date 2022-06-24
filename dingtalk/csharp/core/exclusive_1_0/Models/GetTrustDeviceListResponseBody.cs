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
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// mac地址
            /// </summary>
            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            /// <summary>
            /// 版本信息：Android端: Android,10，IOS端：iOS,12.0.1
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// 平台类型
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 设备状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 员工Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
