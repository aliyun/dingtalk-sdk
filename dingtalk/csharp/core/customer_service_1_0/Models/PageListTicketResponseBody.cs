// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListTicketResponseBody : TeaModel {
        /// <summary>
        /// list
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListTicketResponseBodyList> List { get; set; }
        public class PageListTicketResponseBodyList : TeaModel {
            /// <summary>
            /// foreignId
            /// </summary>
            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            /// <summary>
            /// sourceId
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// foreignName
            /// </summary>
            [NameInMap("foreignName")]
            [Validation(Required=false)]
            public string ForeignName { get; set; }

            /// <summary>
            /// templateId
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// ticketId
            /// </summary>
            [NameInMap("ticketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

            /// <summary>
            /// ticketStatus
            /// </summary>
            [NameInMap("ticketStatus")]
            [Validation(Required=false)]
            public string TicketStatus { get; set; }

            /// <summary>
            /// openInstanceId
            /// </summary>
            [NameInMap("openInstanceId")]
            [Validation(Required=false)]
            public string OpenInstanceId { get; set; }

            /// <summary>
            /// productionType
            /// </summary>
            [NameInMap("productionType")]
            [Validation(Required=false)]
            public int? ProductionType { get; set; }

            /// <summary>
            /// gmtCreate
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// gmtModified
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// bizDataMap
            /// </summary>
            [NameInMap("bizDataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> BizDataMap { get; set; }

        }

        /// <summary>
        /// nextCursor
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// total
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
