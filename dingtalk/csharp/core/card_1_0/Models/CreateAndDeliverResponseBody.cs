// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAndDeliverResponseBodyResult Result { get; set; }
        public class CreateAndDeliverResponseBodyResult : TeaModel {
            [NameInMap("deliverResults")]
            [Validation(Required=false)]
            public List<CreateAndDeliverResponseBodyResultDeliverResults> DeliverResults { get; set; }
            public class CreateAndDeliverResponseBodyResultDeliverResults : TeaModel {
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
