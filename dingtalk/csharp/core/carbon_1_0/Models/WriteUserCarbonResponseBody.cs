// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteUserCarbonResponseBody : TeaModel {
        /// <summary>
        /// 返回请求成功个数
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public int? Result { get; set; }

        /// <summary>
        /// 请求是否写入成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
