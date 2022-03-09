// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetUserOkrRequest : TeaModel {
        /// <summary>
        /// 归属用户的ID
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public Stream OwnerId { get; set; }

        /// <summary>
        /// 页码，默认 为 1
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页的个数，默认100
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 周期 ID
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public Stream PeriodId { get; set; }

    }

}
