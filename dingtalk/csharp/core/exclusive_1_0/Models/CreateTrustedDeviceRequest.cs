// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateTrustedDeviceRequest : TeaModel {
        /// <summary>
        /// 支持SDK集成的设备唯一标识。
        /// </summary>
        [NameInMap("did")]
        [Validation(Required=false)]
        public string Did { get; set; }

        /// <summary>
        /// mac地址
        /// </summary>
        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

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
        /// 员工userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
