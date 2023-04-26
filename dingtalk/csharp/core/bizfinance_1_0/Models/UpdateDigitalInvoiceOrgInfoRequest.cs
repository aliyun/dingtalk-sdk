// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateDigitalInvoiceOrgInfoRequest : TeaModel {
        [NameInMap("digitalInvoiceType")]
        [Validation(Required=false)]
        public List<string> DigitalInvoiceType { get; set; }

        [NameInMap("isDigitalOrg")]
        [Validation(Required=false)]
        public bool? IsDigitalOrg { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
