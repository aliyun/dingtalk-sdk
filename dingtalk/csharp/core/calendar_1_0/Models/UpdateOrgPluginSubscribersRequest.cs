// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class UpdateOrgPluginSubscribersRequest : TeaModel {
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<string> DeptIds { get; set; }

        [NameInMap("unionIds")]
        [Validation(Required=false)]
        public List<string> UnionIds { get; set; }

    }

}
