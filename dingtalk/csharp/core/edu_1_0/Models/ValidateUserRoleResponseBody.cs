// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ValidateUserRoleResponseBody : TeaModel {
        /// <summary>
        /// 是否是家长身份。
        /// true表示是家长，false表示不是家长。
        /// </summary>
        [NameInMap("matchParentIdentity")]
        [Validation(Required=false)]
        public bool? MatchParentIdentity { get; set; }

        /// <summary>
        /// 是否为老师身份。
        /// true表示是老师，false表示不是老师。
        /// </summary>
        [NameInMap("matchTeacherIdentity")]
        [Validation(Required=false)]
        public bool? MatchTeacherIdentity { get; set; }

    }

}
