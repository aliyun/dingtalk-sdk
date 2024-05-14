// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentMemberRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("residentUpdateInfo")]
        [Validation(Required=false)]
        public UpdateResidentMemberRequestResidentUpdateInfo ResidentUpdateInfo { get; set; }
        public class UpdateResidentMemberRequestResidentUpdateInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("isPropertyOwner")]
            [Validation(Required=false)]
            public bool? IsPropertyOwner { get; set; }

            [NameInMap("memberDeptExtension")]
            [Validation(Required=false)]
            public Dictionary<string, string> MemberDeptExtension { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("oldDeptId")]
            [Validation(Required=false)]
            public long? OldDeptId { get; set; }

            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
