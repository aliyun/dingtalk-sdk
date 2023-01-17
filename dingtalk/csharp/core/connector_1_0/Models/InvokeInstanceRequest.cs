// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class InvokeInstanceRequest : TeaModel {
        /// <summary>
        /// 连接资产标识
        /// </summary>
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        /// <summary>
        /// 入参JSON文本
        /// </summary>
        [NameInMap("inputJsonString")]
        [Validation(Required=false)]
        public string InputJsonString { get; set; }

        /// <summary>
        /// 外部实例唯一标识
        /// </summary>
        [NameInMap("instanceKey")]
        [Validation(Required=false)]
        public string InstanceKey { get; set; }

    }

}
