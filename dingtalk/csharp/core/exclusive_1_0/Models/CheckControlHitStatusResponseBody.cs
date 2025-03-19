// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CheckControlHitStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CheckControlHitStatusResponseBodyResult Result { get; set; }
        public class CheckControlHitStatusResponseBodyResult : TeaModel {
            [NameInMap("controlList")]
            [Validation(Required=false)]
            public List<string> ControlList { get; set; }

            [NameInMap("controlStatus")]
            [Validation(Required=false)]
            public int? ControlStatus { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
