// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetResidentMembersInfoResponseBody : TeaModel {
        [NameInMap("residenceList")]
        [Validation(Required=false)]
        public List<GetResidentMembersInfoResponseBodyResidenceList> ResidenceList { get; set; }
        public class GetResidentMembersInfoResponseBodyResidenceList : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("extField")]
            [Validation(Required=false)]
            public string ExtField { get; set; }

            [NameInMap("isPropertyOwner")]
            [Validation(Required=false)]
            public bool? IsPropertyOwner { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

        }

    }

}
