// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class CleanFileRequest : TeaModel {
        [NameInMap("cleanReason")]
        [Validation(Required=false)]
        public string CleanReason { get; set; }

        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public long? DentryId { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

    }

}
