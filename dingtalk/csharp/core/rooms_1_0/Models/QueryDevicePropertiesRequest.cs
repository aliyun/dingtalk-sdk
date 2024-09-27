// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDevicePropertiesRequest : TeaModel {
        [NameInMap("propertyNames")]
        [Validation(Required=false)]
        public List<string> PropertyNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;lmvUrRkpboRrSMtgsiS9V3AiEiE&quot;</para>
        /// </summary>
        [NameInMap("deviceUnionId")]
        [Validation(Required=false)]
        public string DeviceUnionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;lmvUrEjpboFrSMtgsiS9V3AiEiE&quot;</para>
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

    }

}
