// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverAICardResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAndDeliverAICardResponseBodyResult Result { get; set; }
        public class CreateAndDeliverAICardResponseBodyResult : TeaModel {
            [NameInMap("deliverResults")]
            [Validation(Required=false)]
            public List<CreateAndDeliverAICardResponseBodyResultDeliverResults> DeliverResults { get; set; }
            public class CreateAndDeliverAICardResponseBodyResultDeliverResults : TeaModel {
                [NameInMap("carrierId")]
                [Validation(Required=false)]
                public string CarrierId { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>a2ui_order_001</para>
            /// </summary>
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
