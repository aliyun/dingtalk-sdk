// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ShiftAddResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ShiftAddResponseBodyResult Result { get; set; }
        public class ShiftAddResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>白班</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
