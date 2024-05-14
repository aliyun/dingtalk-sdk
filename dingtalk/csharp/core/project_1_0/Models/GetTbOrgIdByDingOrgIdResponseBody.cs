// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTbOrgIdByDingOrgIdResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTbOrgIdByDingOrgIdResponseBodyResult Result { get; set; }
        public class GetTbOrgIdByDingOrgIdResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tbOrganizationId")]
            [Validation(Required=false)]
            public string TbOrganizationId { get; set; }

        }

    }

}
