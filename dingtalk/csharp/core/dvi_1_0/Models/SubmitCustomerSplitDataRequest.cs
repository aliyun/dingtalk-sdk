// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class SubmitCustomerSplitDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("splitParams")]
        [Validation(Required=false)]
        public List<SubmitCustomerSplitDataRequestSplitParams> SplitParams { get; set; }
        public class SubmitCustomerSplitDataRequestSplitParams : TeaModel {
            [NameInMap("outBizData")]
            [Validation(Required=false)]
            public string OutBizData { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
