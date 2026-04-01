// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CleanFileRequest : TeaModel {
        [NameInMap("dentryIds")]
        [Validation(Required=false)]
        public List<CleanFileRequestDentryIds> DentryIds { get; set; }
        public class CleanFileRequestDentryIds : TeaModel {
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public long? DentryId { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

    }

}
