// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class UpdateUserExtendInfoRequest : TeaModel {
        /// <summary>
        /// 职称code
        /// </summary>
        [NameInMap("jobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// 用户属性code
        /// </summary>
        [NameInMap("userProbCode")]
        [Validation(Required=false)]
        public string UserProbCode { get; set; }

        /// <summary>
        /// 工作状态code
        /// </summary>
        [NameInMap("jobStatusCode")]
        [Validation(Required=false)]
        public List<string> JobStatusCode { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        [NameInMap("comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

    }

}
