// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class RenewApplicationAuthorizationServiceOrderRequest : TeaModel {
        /// <summary>
        /// 访问秘钥
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 调用者unionId
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endTimeGMT")]
        [Validation(Required=false)]
        public long? EndTimeGMT { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
