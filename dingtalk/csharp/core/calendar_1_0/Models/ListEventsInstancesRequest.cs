// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsInstancesRequest : TeaModel {
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("startRecurrenceId")]
        [Validation(Required=false)]
        public string StartRecurrenceId { get; set; }

    }

}
