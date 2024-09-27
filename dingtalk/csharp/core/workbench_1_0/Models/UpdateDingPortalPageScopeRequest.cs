// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class UpdateDingPortalPageScopeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("allVisible")]
        [Validation(Required=false)]
        public bool? AllVisible { get; set; }

        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        [NameInMap("roleIds")]
        [Validation(Required=false)]
        public List<long?> RoleIds { get; set; }

        [NameInMap("userids")]
        [Validation(Required=false)]
        public List<string> Userids { get; set; }

    }

}
