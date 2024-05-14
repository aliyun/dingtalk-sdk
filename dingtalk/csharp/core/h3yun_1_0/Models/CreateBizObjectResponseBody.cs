// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class CreateBizObjectResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateBizObjectResponseBodyData Data { get; set; }
        public class CreateBizObjectResponseBodyData : TeaModel {
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            [NameInMap("formUsageType")]
            [Validation(Required=false)]
            public string FormUsageType { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
