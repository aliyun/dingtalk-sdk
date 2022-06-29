// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryCustomerInfoRequest : TeaModel {
        /// <summary>
        /// 客户名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 查询页码，从1开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页查询数量
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [NameInMap("purchaserTaxNo")]
        [Validation(Required=false)]
        public string PurchaserTaxNo { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [NameInMap("purchaserTel")]
        [Validation(Required=false)]
        public string PurchaserTel { get; set; }

    }

}
