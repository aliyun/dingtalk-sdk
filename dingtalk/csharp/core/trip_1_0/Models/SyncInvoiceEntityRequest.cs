// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncInvoiceEntityRequest : TeaModel {
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("delAll")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entityList")]
        [Validation(Required=false)]
        public List<SyncInvoiceEntityRequestEntityList> EntityList { get; set; }
        public class SyncInvoiceEntityRequestEntityList : TeaModel {
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        [NameInMap("invoiceId")]
        [Validation(Required=false)]
        public string InvoiceId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
