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
            /// <summary>
            /// 参与者列表
            /// </summary>
            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers> Involvers { get; set; }
            public class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers : TeaModel {
                /// <summary>
                /// 头像
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// 名字
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 用户uid
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
