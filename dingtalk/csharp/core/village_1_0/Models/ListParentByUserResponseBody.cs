// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListParentByUserResponseBody : TeaModel {
        /// <summary>
        /// 上级部门id链
        /// </summary>
        [NameInMap("parentDeptIdList")]
        [Validation(Required=false)]
        public List<long?> ParentDeptIdList { get; set; }

    }

}
