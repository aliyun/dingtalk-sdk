// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RemoveDeviceFromGroupRequest : TeaModel {
        /// <summary>
        /// 设备编号列表（与设备唯一标识列表二选一）
        /// </summary>
        [NameInMap("deviceCodes")]
        [Validation(Required=false)]
        public List<string> DeviceCodes { get; set; }

        /// <summary>
        /// 设备唯一标识列表（与设备编码列表二选一）
        /// </summary>
        [NameInMap("deviceUuids")]
        [Validation(Required=false)]
        public List<string> DeviceUuids { get; set; }

        /// <summary>
        /// 开放群唯一标识
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 操作人唯一标识
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
