// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureCommonEventResponseBody : TeaModel {
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public IndustryManufactureCommonEventResponseBodyResult Result { get; set; }
        public class IndustryManufactureCommonEventResponseBodyResult : TeaModel {
            /// <summary>
            /// 返回内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 状态码
            /// </summary>
            [NameInMap("httpCode")]
            [Validation(Required=false)]
            public string HttpCode { get; set; }

        }

    }

}
