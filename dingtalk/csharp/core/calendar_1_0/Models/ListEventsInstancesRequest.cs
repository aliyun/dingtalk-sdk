// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cnNTbW1YbxxxxdEgvdlQrQT09</para>
        /// </summary>
        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        [NameInMap("startRecurrenceId")]
        [Validation(Required=false)]
        public string StartRecurrenceId { get; set; }

    }

}
