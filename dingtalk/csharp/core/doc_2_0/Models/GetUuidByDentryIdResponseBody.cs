// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetUuidByDentryIdResponseBody : TeaModel {
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("dentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
