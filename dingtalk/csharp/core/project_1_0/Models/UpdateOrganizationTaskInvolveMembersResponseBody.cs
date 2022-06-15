// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskInvolveMembersResponseBody : TeaModel {
        /// <summary>
        /// 返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskInvolveMembersResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskInvolveMembersResponseBodyResult : TeaModel {
            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> Involvers { get; set; }
            public class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers : TeaModel {
                public string AvatarUrl { get; set; }
                public string Name { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
        };

    }

}
