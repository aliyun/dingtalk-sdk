// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverWithDelegateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAndDeliverWithDelegateResponseBodyResult Result { get; set; }
        public class CreateAndDeliverWithDelegateResponseBodyResult : TeaModel {
            [NameInMap("deliverResults")]
            [Validation(Required=false)]
            public List<CreateAndDeliverWithDelegateResponseBodyResultDeliverResults> DeliverResults { get; set; }
            public class CreateAndDeliverWithDelegateResponseBodyResultDeliverResults : TeaModel {
                [NameInMap("carrierId")]
                [Validation(Required=false)]
                public string CarrierId { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                [NameInMap("spaceType")]
                [Validation(Required=false)]
                public string SpaceType { get; set; }

                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
