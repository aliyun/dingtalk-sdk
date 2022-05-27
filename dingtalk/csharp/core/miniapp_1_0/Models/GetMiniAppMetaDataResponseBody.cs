// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class GetMiniAppMetaDataResponseBody : TeaModel {
        /// <summary>
        /// receiveTime
        /// </summary>
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public long? DingOpenErrcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMiniAppMetaDataResponseBodyResult Result { get; set; }
        public class GetMiniAppMetaDataResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, string> Data { get; set; }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
