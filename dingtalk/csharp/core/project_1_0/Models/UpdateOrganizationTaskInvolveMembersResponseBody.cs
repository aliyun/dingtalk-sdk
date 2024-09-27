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
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxx">http://xxxx</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>鬼斩</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173xxxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-13T05:33:42.826Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
