// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgConfigResponseBody : TeaModel {
        [NameInMap("appDisplayStyle")]
        [Validation(Required=false)]
        public string AppDisplayStyle { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("homepageCatalogs")]
        [Validation(Required=false)]
        public List<string> HomepageCatalogs { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
