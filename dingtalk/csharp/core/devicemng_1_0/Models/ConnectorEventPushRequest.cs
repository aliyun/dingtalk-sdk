// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ConnectorEventPushRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DeviceType-xxxxxx</para>
        /// </summary>
        [NameInMap("deviceTypeUuid")]
        [Validation(Required=false)]
        public string DeviceTypeUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>设备关机</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;var1&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

    }

}
