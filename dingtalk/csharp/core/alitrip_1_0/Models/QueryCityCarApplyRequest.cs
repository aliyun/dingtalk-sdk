// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryCityCarApplyRequest : TeaModel {
        /// <summary>
        /// 第三方企业ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 审批单创建时间小于值
        /// </summary>
        [NameInMap("createdEndAt")]
        [Validation(Required=false)]
        public string CreatedEndAt { get; set; }

        /// <summary>
        /// 审批单创建时间大于等于值
        /// </summary>
        [NameInMap("createdStartAt")]
        [Validation(Required=false)]
        public string CreatedStartAt { get; set; }

        /// <summary>
        /// 页码，要求大于等于1，默认1
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页数据量，要求大于等于1，默认20
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 三方审批单ID
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// 第三方员工ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
