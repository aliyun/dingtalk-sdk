// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sectionIndexList")]
        [Validation(Required=false)]
        public List<long?> SectionIndexList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subscriberIds")]
        [Validation(Required=false)]
        public List<string> SubscriberIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168454674745</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234623456</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168454674745</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("subscriberType")]
        [Validation(Required=false)]
        public string SubscriberType { get; set; }

    }

}
