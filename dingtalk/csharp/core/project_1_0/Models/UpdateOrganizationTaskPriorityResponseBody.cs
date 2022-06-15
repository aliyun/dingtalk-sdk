// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskPriorityResponseBody : TeaModel {
        /// <summary>
        /// 返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskPriorityResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskPriorityResponseBodyResult : TeaModel {
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
        };

    }

}
