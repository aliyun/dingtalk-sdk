// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetProjectMembersV3ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f279e812-e431-428d-846d-cxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetProjectMembersV3ResponseBodyResult> Result { get; set; }
        public class GetProjectMembersV3ResponseBodyResult : TeaModel {
            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
