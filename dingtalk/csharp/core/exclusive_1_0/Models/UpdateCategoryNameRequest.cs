// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class UpdateCategoryNameRequest : TeaModel {
        [NameInMap("currentCategoryName")]
        [Validation(Required=false)]
        public string CurrentCategoryName { get; set; }

        [NameInMap("targetCategoryName")]
        [Validation(Required=false)]
        public string TargetCategoryName { get; set; }

    }

}
