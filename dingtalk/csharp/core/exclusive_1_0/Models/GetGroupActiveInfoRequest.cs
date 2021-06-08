// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupActiveInfoRequest : TeaModel {
        /// <summary>
        /// 统计日期
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

        /// <summary>
        /// 钉钉群组id
        /// </summary>
        [NameInMap("dingGroupId")]
        [Validation(Required=false)]
        public string DingGroupId { get; set; }

        /// <summary>
        /// 分页起始页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
