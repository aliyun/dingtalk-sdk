// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class DeliverCardWithDelegateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DeliverCardWithDelegateResponseBodyResult> Result { get; set; }
        public class DeliverCardWithDelegateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4v+AzUEDuC0dKuO*********J0w8=</para>
            /// </summary>
            [NameInMap("carrierId")]
            [Validation(Required=false)]
            public string CarrierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>system error</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cid1234abcd</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IM_GROUP</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
