// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SetDeptPartnerTypeAndNumRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        [NameInMap("labelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        [NameInMap("partnerNum")]
        [Validation(Required=false)]
        public string PartnerNum { get; set; }

    }

}
