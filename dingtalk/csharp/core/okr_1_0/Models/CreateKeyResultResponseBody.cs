// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateKeyResultResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKeyResultResponseBodyData Data { get; set; }
        public class CreateKeyResultResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
