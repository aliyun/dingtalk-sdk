// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateCategoryAndBindingGroupsRequest : TeaModel {
        [NameInMap("categoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public List<long?> GroupIds { get; set; }

    }

}
