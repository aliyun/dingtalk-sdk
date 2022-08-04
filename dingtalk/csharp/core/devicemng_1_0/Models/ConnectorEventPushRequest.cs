// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ConnectorEventPushRequest : TeaModel {
        /// <summary>
        /// 设备类型唯一标识
        /// </summary>
        [NameInMap("deviceTypeUuid")]
        [Validation(Required=false)]
        public string DeviceTypeUuid { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// 事件入参，json字符串
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

    }

}
