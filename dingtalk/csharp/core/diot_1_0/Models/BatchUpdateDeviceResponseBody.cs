// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchUpdateDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
