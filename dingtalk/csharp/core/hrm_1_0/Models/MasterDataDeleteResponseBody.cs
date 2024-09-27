// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataDeleteResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("allSuccess")]
        [Validation(Required=false)]
        public bool? AllSuccess { get; set; }

        [NameInMap("failResult")]
        [Validation(Required=false)]
        public List<MasterDataDeleteResponseBodyFailResult> FailResult { get; set; }
        public class MasterDataDeleteResponseBodyFailResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>uk123</para>
            /// </summary>
            [NameInMap("bizUK")]
            [Validation(Required=false)]
            public string BizUK { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S0005</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>主键冲突</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
