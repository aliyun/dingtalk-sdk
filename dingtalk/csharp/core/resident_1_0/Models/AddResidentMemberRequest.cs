// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentMemberRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("residentAddInfo")]
        [Validation(Required=false)]
        public AddResidentMemberRequestResidentAddInfo ResidentAddInfo { get; set; }
        public class AddResidentMemberRequestResidentAddInfo : TeaModel {
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
            public Dictionary<string, object> MemberDeptExtension { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

        }

    }

}
