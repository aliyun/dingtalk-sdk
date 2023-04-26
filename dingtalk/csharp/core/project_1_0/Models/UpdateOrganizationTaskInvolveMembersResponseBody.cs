// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskInvolveMembersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskInvolveMembersResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskInvolveMembersResponseBodyResult : TeaModel {
            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> Involvers { get; set; }
            public class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
