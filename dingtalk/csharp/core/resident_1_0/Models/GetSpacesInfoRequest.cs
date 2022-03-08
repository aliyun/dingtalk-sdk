// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetSpacesInfoRequest : TeaModel {
        [NameInMap("referIds")]
        [Validation(Required=false)]
        public List<long?> ReferIds { get; set; }

        [NameInMap("residentCorpId")]
        [Validation(Required=false)]
        public string ResidentCorpId { get; set; }

    }

}
