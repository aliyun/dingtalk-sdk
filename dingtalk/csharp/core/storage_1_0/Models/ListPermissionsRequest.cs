// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListPermissionsRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListPermissionsRequestOption Option { get; set; }
        public class ListPermissionsRequestOption : TeaModel {
            [NameInMap("filterRoleIds")]
            [Validation(Required=false)]
            public List<string> FilterRoleIds { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
