// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentMemberRequest : TeaModel {
        /// <summary>
        /// 人员信息
        /// </summary>
        [NameInMap("residentAddInfo")]
        [Validation(Required=false)]
        public AddResidentMemberRequestResidentAddInfo ResidentAddInfo { get; set; }
        public class AddResidentMemberRequestResidentAddInfo : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 是否是产权人
            /// </summary>
            [NameInMap("isPropertyOwner")]
            [Validation(Required=false)]
            public bool? IsPropertyOwner { get; set; }

            /// <summary>
            /// 人员扩展信息，目前只有租客的起止时间
            /// </summary>
            [NameInMap("memberDeptExtension")]
            [Validation(Required=false)]
            public Dictionary<string, object> MemberDeptExtension { get; set; }

            /// <summary>
            /// 手机号
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 身份，1：业主，2：租客，3：亲友
            /// </summary>
            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

        }

    }

}
