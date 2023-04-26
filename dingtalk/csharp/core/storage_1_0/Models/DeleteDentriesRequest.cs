// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentriesRequest : TeaModel {
        [NameInMap("dentryIds")]
        [Validation(Required=false)]
        public List<string> DentryIds { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public DeleteDentriesRequestOption Option { get; set; }
        public class DeleteDentriesRequestOption : TeaModel {
            [NameInMap("toRecycleBin")]
            [Validation(Required=false)]
            public bool? ToRecycleBin { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
