// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupActiveInfoRequest : TeaModel {
        [NameInMap("dingGroupId")]
        [Validation(Required=false)]
        public string DingGroupId { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public long? GroupType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
