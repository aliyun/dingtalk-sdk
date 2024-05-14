// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsRequest : TeaModel {
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("showDeleted")]
        [Validation(Required=false)]
        public bool? ShowDeleted { get; set; }

        [NameInMap("syncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

        /// <summary>
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("timeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        /// <summary>
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("timeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
