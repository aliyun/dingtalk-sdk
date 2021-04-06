// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeleteGuardianRequest : TeaModel {
        /// <summary>
        /// 学生ID
        /// </summary>
        [NameInMap("stuId")]
        [Validation(Required=false)]
        public string StuId { get; set; }

        /// <summary>
        /// 钉钉企业管理员员工ID
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
