// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripInvoiceShrinkRequest : TeaModel {
        [NameInMap("channelOrderNo")]
        [Validation(Required=false)]
        public string ChannelOrderNo { get; set; }

        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("customerCorpId")]
        [Validation(Required=false)]
        public string CustomerCorpId { get; set; }

        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        [NameInMap("invoiceDetailList")]
        [Validation(Required=false)]
        public string InvoiceDetailListShrink { get; set; }

    }

}
