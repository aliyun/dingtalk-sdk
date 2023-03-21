// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateDigitalInvoiceOrgInfoRequest : TeaModel {
        /// <summary>
        /// 支持的全电票种
        /// </summary>
        [NameInMap("digitalInvoiceType")]
        [Validation(Required=false)]
        public List<string> DigitalInvoiceType { get; set; }

        /// <summary>
        /// 是否为全电企业
        /// </summary>
        [NameInMap("isDigitalOrg")]
        [Validation(Required=false)]
        public bool? IsDigitalOrg { get; set; }

        /// <summary>
        /// 报税地点
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
