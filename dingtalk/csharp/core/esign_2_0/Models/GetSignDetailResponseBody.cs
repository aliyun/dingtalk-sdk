// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetSignDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("businessScene")]
        [Validation(Required=false)]
        public string BusinessScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("flowStatus")]
        [Validation(Required=false)]
        public float? FlowStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("signers")]
        [Validation(Required=false)]
        public List<GetSignDetailResponseBodySigners> Signers { get; set; }
        public class GetSignDetailResponseBodySigners : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("signStatus")]
            [Validation(Required=false)]
            public float? SignStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("signerName")]
            [Validation(Required=false)]
            public string SignerName { get; set; }

        }

    }

}
