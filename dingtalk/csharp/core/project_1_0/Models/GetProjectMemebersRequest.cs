// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("projectRoleId")]
        [Validation(Required=false)]
        public string ProjectRoleId { get; set; }

        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
