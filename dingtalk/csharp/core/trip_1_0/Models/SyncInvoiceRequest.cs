// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncInvoiceRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("bankName")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        [NameInMap("bankNo")]
        [Validation(Required=false)]
        public string BankNo { get; set; }

        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("deleteFlag")]
        [Validation(Required=false)]
        public bool? DeleteFlag { get; set; }

        [NameInMap("gmtAction")]
        [Validation(Required=false)]
        public string GmtAction { get; set; }

        [NameInMap("invoiceId")]
        [Validation(Required=false)]
        public string InvoiceId { get; set; }

        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public List<string> ProjectIds { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        [NameInMap("tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        [NameInMap("thirdPartId")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("unitType")]
        [Validation(Required=false)]
        public int? UnitType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
