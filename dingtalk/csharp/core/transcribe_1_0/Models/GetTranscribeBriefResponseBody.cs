// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class GetTranscribeBriefResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTranscribeBriefResponseBodyData Data { get; set; }
        public class GetTranscribeBriefResponseBodyData : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }
        };

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 用于描述本次请求是否成功的字段
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
