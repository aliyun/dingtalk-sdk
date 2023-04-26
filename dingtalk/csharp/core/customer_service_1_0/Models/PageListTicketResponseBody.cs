// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListTicketResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListTicketResponseBodyList> List { get; set; }
        public class PageListTicketResponseBodyList : TeaModel {
            [NameInMap("bizDataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> BizDataMap { get; set; }

            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            [NameInMap("foreignName")]
            [Validation(Required=false)]
            public string ForeignName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("openInstanceId")]
            [Validation(Required=false)]
            public string OpenInstanceId { get; set; }

            [NameInMap("productionType")]
            [Validation(Required=false)]
            public int? ProductionType { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("ticketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

            [NameInMap("ticketStatus")]
            [Validation(Required=false)]
            public string TicketStatus { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
