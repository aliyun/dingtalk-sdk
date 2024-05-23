// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalTeamDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

    }

}
