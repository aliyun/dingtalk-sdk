// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class UpdateUserExtendInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        [NameInMap("jobStatusCode")]
        [Validation(Required=false)]
        public List<string> JobStatusCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userProbCode")]
        [Validation(Required=false)]
        public string UserProbCode { get; set; }

    }

}
