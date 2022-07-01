// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class UpdatePermissionForUsersRequest : TeaModel {
        /// <summary>
        /// 闪记任务的类型。枚举值，从任务详情中获取。
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// 被授权的用户信息列表
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdatePermissionForUsersRequestMembers> Members { get; set; }
        public class UpdatePermissionForUsersRequestMembers : TeaModel {
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// 要赋予用户的权限名称。该字段表示要授予特定用户的权限名称，由开发者填写。
            /// 
            /// EDITOR：可编辑权限
            /// 
            /// READ_DOWNLOAD：仅可查看、下载
            /// 
            /// READ：只读权限
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// 要操作的闪记任务的创建者userId。
        /// </summary>
        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        /// <summary>
        /// 闪记任务的特定标识。是一个不定长的字符串。
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
