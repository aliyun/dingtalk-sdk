// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class InsertDropdownListsRequest : TeaModel {
        [NameInMap("options")]
        [Validation(Required=false)]
        public List<InsertDropdownListsRequestOptions> Options { get; set; }
        public class InsertDropdownListsRequestOptions : TeaModel {
            [NameInMap("color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
