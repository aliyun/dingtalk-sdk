// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class RemovePermissionRequest : TeaModel {
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<RemovePermissionRequestMembers> Members { get; set; }
        public class RemovePermissionRequestMembers : TeaModel {
            /// <summary>
            /// 执行授权操作的闪记任务的任务Id
            /// </summary>
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

            /// <summary>
            /// 要被移除的权限，枚举值类型。
            /// "EDITOR", //可编辑权限
            ///     "READ_DOWNLOAD", //仅可查看、下载的权限
            ///     "READ"//只读权限
            /// 
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// 任务的创建者uid
        /// </summary>
        [NameInMap("taskCreator")]
        [Validation(Required=false)]
        public long? TaskCreator { get; set; }

        /// <summary>
        /// 闪记任务的闪记ID
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
