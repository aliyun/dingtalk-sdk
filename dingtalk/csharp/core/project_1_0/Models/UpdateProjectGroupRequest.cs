// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateProjectGroupRequest : TeaModel {
        /// <summary>
        /// 增加到项目分组的Id列表，最多5个
        /// </summary>
        [NameInMap("addProjectGroupIds")]
        [Validation(Required=false)]
        public List<string> AddProjectGroupIds { get; set; }

        /// <summary>
        /// 移除项目分组的Id列表，最多5个
        /// </summary>
        [NameInMap("delProjectGroupIds")]
        [Validation(Required=false)]
        public List<string> DelProjectGroupIds { get; set; }

    }

}
