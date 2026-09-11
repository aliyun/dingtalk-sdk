// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class DeptGroupSettingUpdateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("groupContainHiddenDept")]
        [Validation(Required=false)]
        public bool? GroupContainHiddenDept { get; set; }

        [NameInMap("groupContainHrmEmployeeTypeLabels")]
        [Validation(Required=false)]
        public List<string> GroupContainHrmEmployeeTypeLabels { get; set; }

        [NameInMap("groupContainOuterDept")]
        [Validation(Required=false)]
        public bool? GroupContainOuterDept { get; set; }

        [NameInMap("groupContainSubDept")]
        [Validation(Required=false)]
        public bool? GroupContainSubDept { get; set; }

        [NameInMap("permissionCode")]
        [Validation(Required=false)]
        public string PermissionCode { get; set; }

        [NameInMap("syncMembers")]
        [Validation(Required=false)]
        public bool? SyncMembers { get; set; }

    }

}
