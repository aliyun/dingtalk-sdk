// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryMedicalEventsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryMedicalEventsResponseBodyContent> Content { get; set; }
        public class QueryMedicalEventsResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
