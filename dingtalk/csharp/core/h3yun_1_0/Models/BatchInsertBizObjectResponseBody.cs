// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class BatchInsertBizObjectResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchInsertBizObjectResponseBodyData Data { get; set; }
        public class BatchInsertBizObjectResponseBodyData : TeaModel {
            [NameInMap("bizObjectIds")]
            [Validation(Required=false)]
            public List<string> BizObjectIds { get; set; }

            [NameInMap("failedDatas")]
            [Validation(Required=false)]
            public List<string> FailedDatas { get; set; }

            [NameInMap("failedMessages")]
            [Validation(Required=false)]
            public List<string> FailedMessages { get; set; }

            [NameInMap("processIds")]
            [Validation(Required=false)]
            public List<string> ProcessIds { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
