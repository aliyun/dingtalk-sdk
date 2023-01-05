// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessRegularRequest : TeaModel {
        /// <summary>
        /// 操作人用户ID
        /// </summary>
        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// 转正时间
        /// </summary>
        [NameInMap("regularDate")]
        [Validation(Required=false)]
        public long? RegularDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
