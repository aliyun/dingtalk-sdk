// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateFollowRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchUpdateFollowRecordsResponseBodyResults> Results { get; set; }
        public class BatchUpdateFollowRecordsResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>查重失败</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yU9TbER1TDazjPq1rRCzwg04841675924041</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
