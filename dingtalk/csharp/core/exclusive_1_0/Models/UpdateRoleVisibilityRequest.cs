// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateRoleVisibilityRequest : TeaModel {
        /// <summary>
        /// 可见的部门id
        /// </summary>
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        [NameInMap("dingClientId")]
        [Validation(Required=false)]
        public string DingClientId { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [NameInMap("labelId")]
        [Validation(Required=false)]
        public long? LabelId { get; set; }

        /// <summary>
        /// 可见的员工id
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
