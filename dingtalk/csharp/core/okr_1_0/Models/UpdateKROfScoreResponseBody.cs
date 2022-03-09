// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfScoreResponseBody : TeaModel {
        /// <summary>
        /// 目标分数
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
