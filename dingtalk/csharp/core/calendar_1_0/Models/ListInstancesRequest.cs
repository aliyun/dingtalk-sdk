// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("timeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("timeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
