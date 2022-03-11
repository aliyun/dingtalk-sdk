// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetSignedDetailByPageRequest : TeaModel {
        /// <summary>
        /// pageStart
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// signStatus
        /// </summary>
        [NameInMap("signStatus")]
        [Validation(Required=false)]
        public long? SignStatus { get; set; }

    }

}
