// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateProjectGroupRequest : TeaModel {
        [NameInMap("addProjectGroupIds")]
        [Validation(Required=false)]
        public List<string> AddProjectGroupIds { get; set; }

        [NameInMap("delProjectGroupIds")]
        [Validation(Required=false)]
        public List<string> DelProjectGroupIds { get; set; }

    }

}
