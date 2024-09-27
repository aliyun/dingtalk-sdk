// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class DeviceDingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("deviceKey")]
        [Validation(Required=false)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>json字符串</para>
        /// </summary>
        [NameInMap("paramsJson")]
        [Validation(Required=false)]
        public string ParamsJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

    }

}
