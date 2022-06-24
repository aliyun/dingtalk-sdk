// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class PushDingMessageResponseBody : TeaModel {
        /// <summary>
        /// 返回1表示当前批次成功
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public long? Content { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
