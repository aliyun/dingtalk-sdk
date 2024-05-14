// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetSignDetailResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("businessScene")]
        [Validation(Required=false)]
        public string BusinessScene { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("flowStatus")]
        [Validation(Required=false)]
        public float? FlowStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signers")]
        [Validation(Required=false)]
        public List<GetSignDetailResponseBodySigners> Signers { get; set; }
        public class GetSignDetailResponseBodySigners : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("signStatus")]
            [Validation(Required=false)]
            public float? SignStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("signerName")]
            [Validation(Required=false)]
            public string SignerName { get; set; }

        }

    }

}
