// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeleteTeacherRequest : TeaModel {
        /// <summary>
        /// 是否班主任；1:班主任；0:非班主任
        /// </summary>
        [NameInMap("adviser")]
        [Validation(Required=false)]
        public int? Adviser { get; set; }

        /// <summary>
        /// 钉钉企业管理员员工ID
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
