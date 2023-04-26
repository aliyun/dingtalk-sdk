// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataListRequest : TeaModel {
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public string Datatype { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("pagesize")]
        [Validation(Required=false)]
        public long? Pagesize { get; set; }

    }

}
