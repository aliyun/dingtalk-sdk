// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListCategorysRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ListCategorysRequestBody Body { get; set; }
        public class ListCategorysRequestBody : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

    }

}
