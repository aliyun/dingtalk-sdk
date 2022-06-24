// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryOrgPointDetailsRequest : TeaModel {
        /// <summary>
        /// 查询企业账号明细，ORG,ORG_DEDUCTIONS两种。     ORG:企业账户明细 查询的是企业积分发放明细       ORG_DEDUCTIONS:扣除账户明细，查询的是企业扣减积分明细
        /// </summary>
        [NameInMap("accountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// 查询页数 第一页是1 非空必传
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页大小最多50，默认10
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 操作人userId 必须是管理员
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
