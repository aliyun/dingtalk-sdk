// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class PullDeviceToGroupRequest : TeaModel {
        /// <summary>
        /// 设备业务标识
        /// </summary>
        [NameInMap("deviceCodes")]
        [Validation(Required=false)]
        public List<string> DeviceCodes { get; set; }

        /// <summary>
        /// 设备uuid，系统唯一标识
        /// </summary>
        [NameInMap("deviceUuids")]
        [Validation(Required=false)]
        public List<string> DeviceUuids { get; set; }

        /// <summary>
        /// 群id，群的唯一标识
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
