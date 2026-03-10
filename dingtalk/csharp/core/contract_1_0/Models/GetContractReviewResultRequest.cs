// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractReviewResultRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetContractReviewResultRequestBody Body { get; set; }
        public class GetContractReviewResultRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("reviewType")]
            [Validation(Required=false)]
            public string ReviewType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
