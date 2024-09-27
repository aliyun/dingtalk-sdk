// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allSuccess")]
        [Validation(Required=false)]
        public bool? AllSuccess { get; set; }

        [NameInMap("failResult")]
        [Validation(Required=false)]
        public List<MasterDataSaveResponseBodyFailResult> FailResult { get; set; }
        public class MasterDataSaveResponseBodyFailResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>uk123</para>
            /// </summary>
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

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
