// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class RollbackMiniAppVersionResponseBody : TeaModel {
        /// <summary>
        /// 失败原因
        /// </summary>
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

    }

}
