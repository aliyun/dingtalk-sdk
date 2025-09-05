// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripInvoiceRequest : TeaModel {
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
        public List<SyncTripInvoiceRequestInvoiceDetailList> InvoiceDetailList { get; set; }
        public class SyncTripInvoiceRequestInvoiceDetailList : TeaModel {
            [NameInMap("failCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            [NameInMap("failMessage")]
            [Validation(Required=false)]
            public string FailMessage { get; set; }

            [NameInMap("invoiceResult")]
            [Validation(Required=false)]
            public bool? InvoiceResult { get; set; }

            [NameInMap("ofdInvoiceUrl")]
            [Validation(Required=false)]
            public string OfdInvoiceUrl { get; set; }

            [NameInMap("pdfInvoiceUrl")]
            [Validation(Required=false)]
            public string PdfInvoiceUrl { get; set; }

            [NameInMap("travelItineraryInfoList")]
            [Validation(Required=false)]
            public List<SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList> TravelItineraryInfoList { get; set; }
            public class SyncTripInvoiceRequestInvoiceDetailListTravelItineraryInfoList : TeaModel {
                [NameInMap("travelItineraryUrl")]
                [Validation(Required=false)]
                public string TravelItineraryUrl { get; set; }

            }

            [NameInMap("xmlInvoiceUrl")]
            [Validation(Required=false)]
            public string XmlInvoiceUrl { get; set; }

        }

    }

}
